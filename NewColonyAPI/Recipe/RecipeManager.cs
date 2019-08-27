using PhentrixGames.NewColonyAPI.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PhentrixGames.NewColonyAPI.Recipe
{
    [ModLoader.ModManager]
    public class RecipeManager
    {
        [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
        public class NCAPIRecipe : Attribute { }

        private static List<BaseType> TypesThatHaveRecipes = new List<BaseType>();

        public static void AddTypeWithRecipe(BaseType type)
        {
            TypesThatHaveRecipes.Add(type);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, NewColonyAPIEntry.Naming + "AfterItemTypesDefinedPlayer")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.recipeplayerload")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.recipenpcload")]
        internal static void AutoDiscoverRecipes()
        {
            int count = 0;
            foreach (string modname in Mods.ModManager.GetMods().Keys)
            {
                Mods.Mod mod = Mods.ModManager.GetMod(modname);
                Assembly assembly = Mods.ModManager.GetAssembly(mod.ModName);
                var recipelist = assembly.GetTypes()
                    .Where(t => (t.IsClass && t.IsDefined(typeof(NCAPIRecipe), true)));
                foreach (var t in recipelist)
                {
                    try
                    {
                        BaseRecipe recipe = ((BaseRecipe)Activator.CreateInstance(t));
                        recipe.RegisterRecipe();
                        count++;
                    }
                    catch (MissingFieldException mfe)
                    {
                        Helpers.Logging.WriteLog(modname,
                            t.Name + " cannot be instantiated.  This probably isn't an error. " + mfe.Message + " |||| " + mfe.StackTrace,
                            Helpers.Logging.LogType.Issue);
                    }
                    catch (InvalidCastException ice)
                    {
                        Helpers.Logging.WriteLog(modname, t.Name + " doesn't properly implement our Type system. This probably isn't an error. " + ice.Message + " |||| " + ice.StackTrace,
                            Helpers.Logging.LogType.Issue);
                    }
                    catch (Exception e)
                    {
                        Helpers.Logging.WriteLog(modname, t.Name + " Recipe Error: " + e.Message + "\n" + e.StackTrace + "\n\n" + e.InnerException.Message + "\n" + e.InnerException.StackTrace,
                            Helpers.Logging.LogType.Issue,
                            true);
                    }
                }

                if (Power.PowerManager.IsEnabled())
                {
                    var powerlist = assembly.GetTypes()
                        .Where(t => (t.IsClass && t.IsDefined(typeof(Power.PowerManager.NCAPIPowerRecipe), true)));
                    foreach (var tpower in powerlist)
                    {
                        try
                        {
                            BaseRecipe recipe = ((BaseRecipe)Activator.CreateInstance(tpower));
                            recipe.RegisterRecipe();
                            count++;
                        }
                        catch (MissingFieldException mfe)
                        {
                            Helpers.Logging.WriteLog(modname,
                                t.Name + " cannot be instantiated.  This probably isn't an error. " + mfe.Message + " |||| " + mfe.StackTrace,
                                Helpers.Logging.LogType.Issue);
                        }
                        catch (InvalidCastException ice)
                        {
                            Helpers.Logging.WriteLog(modname, t.Name + " doesn't properly implement our Type system. This probably isn't an error. " + ice.Message + " |||| " + ice.StackTrace,
                                Helpers.Logging.LogType.Issue);
                        }
                        catch (Exception e)
                        {
                            Helpers.Logging.WriteLog(modname, t.Name + " Recipe Error: " + e.Message + "\n" + e.StackTrace + "\n\n" + e.InnerException.Message + "\n" + e.InnerException.StackTrace,
                                Helpers.Logging.LogType.Issue,
                                true);
                        }
                    }
                }
            }
            foreach (var type in TypesThatHaveRecipes)
            {
            }
            Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Recipes Autoloaded: " + count, Helpers.Logging.LogType.Loading);
        }
    }
}
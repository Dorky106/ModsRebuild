using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Types
{
    [ModLoader.ModManager]
    public static class TypesManager
    {
        [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
        public class NCAPIType : Attribute { }



        [ModLoader.ModCallback(ModLoader.EModCallbackType.AddItemTypes, NewColonyAPIEntry.Naming + "AddItemTypes")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.applymoditempatches")]
        internal static void AutoDiscoverType(Dictionary<string, ItemTypesServer.ItemTypeRaw> dict)
        {
            int typecount = 0;

            foreach (string modname in Mods.ModManager.GetMods().Keys)
            {
                Mods.Mod mod = Mods.ModManager.GetMod(modname);
                Assembly assembly = Mods.ModManager.GetAssembly(mod.ModName);
                var typelist = assembly.GetTypes()
                    .Where(t => (t.IsClass && t.IsDefined(typeof(NCAPIType), true)));

                foreach (var type in typelist)
                {
                    try
                    {
                        BaseType @base = ((BaseType)Activator.CreateInstance(type) as BaseType);
                        JSONNode typenode = @base.Register();
                        if (@base.OverrideReplace)
                        {
                            ItemTypesServer.QueueItemTypePatch(@base.TypeName, ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, typenode, typecount);
                        }
                        else
                        {
                            ItemTypesServer.QueueItemTypePatch(@base.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, typenode, typecount);
                        }
                        typecount++;
                    }
                    catch (MissingFieldException mfe)
                    {
                        Helpers.Logging.WriteLog(mod.ModName, type.Name + " cannot be instantiated.  This probably is not an error. " + mfe.Message + " |||| " + mfe.StackTrace, Helpers.Logging.LogType.Issue, true);
                    }
                    catch (InvalidCastException ice)
                    {
                        Helpers.Logging.WriteLog(mod.ModName, type.Name + " does not properly implement our Type System. This probably is not an error. " + ice.Message + " |||| " + ice.StackTrace, Helpers.Logging.LogType.Issue, true);
                    }
                    catch (Exception e)
                    {
                        Helpers.Logging.WriteLog(mod.ModName, type.Name + " Type Error: " + e.Message + "\n" + e.StackTrace + "\n\n" + e.InnerException.Message + "\n" + e.InnerException.StackTrace, Helpers.Logging.LogType.Issue, true);
                    }
                }
            }
        }
    }
}

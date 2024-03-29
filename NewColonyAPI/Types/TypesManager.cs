﻿using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PhentrixGames.NewColonyAPI.Types
{
    [ModLoader.ModManager]
    public static class TypesManager
    {
        [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
        public class NCAPIType : Attribute { }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AddItemTypes, NewColonyAPIEntry.Naming + "AddItemTypes")]
        [ModLoader.ModCallbackProvidesFor(NewColonyAPIEntry.Naming + "ClearMeshs")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.applymoditempatches")]
#pragma warning disable IDE0060 // Remove unused parameter
        internal static void AutoDiscoverType(Dictionary<string, ItemTypesServer.ItemTypeRaw> dict)
#pragma warning restore IDE0060 // Remove unused parameter
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
                        BaseType @base = ((BaseType)Activator.CreateInstance(type));
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

                string[] directories = Directory.GetDirectories(mod.ModFolder, "*", SearchOption.AllDirectories);
                foreach (string dir in directories)
                {
                    if (dir.EndsWith("typesadd"))
                    {
                        string[] files = Directory.GetFiles(dir, "*.json", SearchOption.AllDirectories);
                        foreach (string file in files)
                        {
                            ItemTypesServer.QueueItemTypePatches(file, ItemTypesServer.EItemTypePatchType.AddNewTypes, 1);
                        }
                    }
                    if (dir.EndsWith("typesreplace"))
                    {
                        string[] files = Directory.GetFiles(dir, "*.json", SearchOption.AllDirectories);
                        foreach (string file in files)
                        {
                            ItemTypesServer.QueueItemTypePatches(file, ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 1);
                        }
                    }
                }

                if (Power.PowerManager.IsEnabled())
                {
                    var powerlist = assembly.GetTypes()
                        .Where(t => (t.IsClass && t.IsDefined(typeof(Power.PowerManager.NCAPIPowerType), true)));
                    foreach (var power in powerlist)
                    {
                        try
                        {
                            BaseType baseType = ((BaseType)Activator.CreateInstance(power));
                            JSONNode typenode = baseType.Register();
                            if (baseType.OverrideReplace)
                            {
                                ItemTypesServer.QueueItemTypePatch(baseType.TypeName, ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, typenode, typecount);
                            }
                            else
                            {
                                ItemTypesServer.QueueItemTypePatch(baseType.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, typenode, typecount);
                            }
                        }
                        catch (MissingFieldException mfe)
                        {
                            Helpers.Logging.WriteLog(mod.ModName, power.Name + " cannot be instantiated.  This probably is not an error. " + mfe.Message + " |||| " + mfe.StackTrace, Helpers.Logging.LogType.Issue, true);
                        }
                        catch (InvalidCastException ice)
                        {
                            Helpers.Logging.WriteLog(mod.ModName, power.Name + " does not properly implement our Power Type System. This probably is not an error. " + ice.Message + " |||| " + ice.StackTrace, Helpers.Logging.LogType.Issue, true);
                        }
                        catch (Exception e)
                        {
                            Helpers.Logging.WriteLog(mod.ModName, power.Name + "Power Type Error: " + e.Message + "\n" + e.StackTrace + "\n\n" + e.InnerException.Message + "\n" + e.InnerException.StackTrace, Helpers.Logging.LogType.Issue, true);
                        }
                    }
                }
            }
            Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, string.Format("Autoloaded {0} blocks/types", typecount), Helpers.Logging.LogType.Loading);
        }
    }
}
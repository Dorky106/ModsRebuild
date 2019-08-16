using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.IO;

namespace PhentrixGames.NewColonyAPI.Configuration
{
    [ModLoader.ModManager]
    public static class ConfigManager
    {
        public static Dictionary<string, JSONNode> configsetings = new Dictionary<string, JSONNode>();

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, NewColonyAPIEntry.Naming + "LoadConfigs")]
        [ModLoader.ModCallbackDependsOn(NewColonyAPIEntry.Naming + "CreateLogs")]
        internal static void LoadConfigs()
        {
            foreach (Mods.Mod mod in Mods.ModManager.GetMods().Values)
            {
                if (mod.ModName != null && mod.ModName != "")
                    if (mod.ConfigLocation != null)
                        RegisterConfig(mod.ModName, mod.ConfigLocation, mod.FileName);
            }
        }

        private static void RegisterConfig(string modname, string configLocation, string filename = "config.json")
        {
            if (configsetings.ContainsKey(modname) == false)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, string.Format("Loading configuration file for {0}", modname), Helpers.Logging.LogType.Loading);
                if (File.Exists(GetWorldConfigLocation(modname)) == false)
                {
                    Helpers.Utilities.MakeDirectoryIfNeeded(Helpers.Utilities.MultiCombine(NewColonyAPIEntry.GameSaveFolder, ServerManager.WorldName, "configs"));
                    Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, configLocation + " " + filename, Helpers.Logging.LogType.Info, true);
                    File.Copy(GetConfigLocation(configLocation, filename), GetWorldConfigLocation(modname));
                }
                try
                {
                    JSONNode confignode = new JSONNode(NodeType.Object);
                    JSON.Deserialize(GetWorldConfigLocation(modname), out confignode, true);
                    configsetings.Add(modname, confignode);
                }
                catch (Exception e)
                {
                    Helpers.Logging.WriteLog(modname, "Error loading configuration! " + e.Message + " : " + e.StackTrace, Helpers.Logging.LogType.Error, true);
                }
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, string.Format("Successfully loading configuration file for {0}", modname), Helpers.Logging.LogType.Loading);
            }
        }

        public static JSONNode GetConfigDataNode(string modname)
        {
            if (configsetings.ContainsKey(modname))
                return configsetings[modname];

            //SHOULD NEVER HAPPEN!
            return new JSONNode(NodeType.Object);
        }

        public static string GetConfigStringOrDefault(string modname, string key, string defaultvalue)
        {
            JSONNode configNode = GetConfigDataNode(modname);
            string[] keys = key.Split('.');
            if (keys.Length > 0)
            {
                return GetConfigStringFromNode(keys, 0, configNode, modname, defaultvalue, key);
            }
            else
            {
                if (configNode.TryGetAs<string>(key, out string result))
                {
                    return result;
                }
                configNode.SetAs(key, defaultvalue);
                RewriteConfig(modname);
                return defaultvalue;
            }
        }

        private static string GetConfigStringFromNode(string[] keys, int keyIndex, JSONNode node, string modname, string defaultvalue, string key)
        {
            try
            {
                if (keys.Length > 0 && keyIndex < keys.Length - 1)
                {
                    if (node.HasChild(keys[keyIndex]))
                    {
                        JSONNode c = new JSONNode(NodeType.Object);
                        c = node.GetAs<JSONNode>(keys[keyIndex]);
                        return GetConfigStringFromNode(keys, keyIndex + 1, c, modname, defaultvalue, key);
                    }
                    else
                    {
                        JSONNode c = new JSONNode(NodeType.Object);
                        node.SetAs(keys[keyIndex], c);
                        return GetConfigStringFromNode(keys, keyIndex + 1, c, modname, defaultvalue, key);
                    }
                }
                else
                {
                    if (node.TryGetAs<string>(keys[keyIndex], out string value) == true && value != null && value != "")
                    {
                        return value;
                    }
                    node.SetAs(keys[keyIndex], defaultvalue);
                    RewriteConfig(modname);
                    return defaultvalue;
                }
            }
            catch (Exception e)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName,
                    "Error loading configuration (" + modname + "): " + key + " - " + keyIndex.ToString() + "\n" + e.Message + "\n\n" + e.StackTrace, Helpers.Logging.LogType.Issue);

                Helpers.Logging.WriteLog(modname,
                    "Error loading configuration (" + modname + "): " + key + " - " + keyIndex.ToString() + "\n" + e.Message + "\n\n" + e.StackTrace, Helpers.Logging.LogType.Issue, true, true);
                return "";
            }
        }

        public static bool GetConfigBooleanOrDefault(string modname, string key, bool defaultvalue)
        {
            JSONNode configNode = GetConfigDataNode(modname);

            string[] keys = key.Split('.');

            if (keys.Length > 0)
            {
                return GetConfigBoolFromNode(keys, 0, configNode, modname, defaultvalue, key);
            }
            else
            {
                bool result = false;
                if (configNode.TryGetAs<bool>(key, out result) == false)
                {
                    result = defaultvalue;
                    configNode.SetAs(key, defaultvalue);
                    RewriteConfig(modname);
                }

                return result;
            }
        }

        private static bool GetConfigBoolFromNode(string[] keys, int keyIndex, JSONNode node, string modname, bool defaultvalue, string key)
        {
            try
            {
                if (keys.Length > 0 && keyIndex < keys.Length - 1)
                {
                    if (node.HasChild(keys[keyIndex]))
                    {
                        // has child
                        JSONNode c = new JSONNode(NodeType.Object);
                        c = node.GetAs<JSONNode>(keys[keyIndex]);
                        return GetConfigBoolFromNode(keys, keyIndex + 1, c, modname, defaultvalue, key);
                    }
                    else
                    {
                        JSONNode c = new JSONNode(NodeType.Object);
                        node.SetAs(keys[keyIndex], c);
                        return GetConfigBoolFromNode(keys, keyIndex + 1, c, modname, defaultvalue, key);
                    }
                }
                else
                {
                    if (node.TryGetAs<bool>(keys[keyIndex], out bool value) == true)
                    {
                        return value;
                    }
                    node.SetAs(keys[keyIndex], defaultvalue);
                    RewriteConfig(modname);
                    return defaultvalue;
                }
            }
            catch (Exception e)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName,
                    "Error loading configuration (" + modname + "): " + key + " - " + keyIndex.ToString() + "\n" + e.Message + "\n\n" + e.StackTrace, Helpers.Logging.LogType.Issue);

                Helpers.Logging.WriteLog(modname,
                    "Error loading configuration (" + modname + "): " + key + " - " + keyIndex.ToString() + "\n" + e.Message + "\n\n" + e.StackTrace, Helpers.Logging.LogType.Issue, true, true);
                return false;
            }
        }

        public static int GetConfigIntOrDefault(string modname, string key, int defaultvalue)
        {
            JSONNode configNode = GetConfigDataNode(modname);

            string[] keys = key.Split('.');

            if (keys.Length > 0)
            {
                return GetConfigIntFromNode(keys, 0, configNode, modname, defaultvalue, key);
            }
            else
            {
                int result = 0;
                if (configNode.TryGetAs<int>(key, out result) == false)
                {
                    result = defaultvalue;
                    configNode.SetAs(key, defaultvalue);
                    RewriteConfig(modname);
                }
                return result;
            }
        }

        private static int GetConfigIntFromNode(string[] keys, int keyIndex, JSONNode node, string modname, int defaultvalue, string key)
        {
            try
            {
                if (keys.Length > 0 && keyIndex < keys.Length - 1)
                {
                    if (node.HasChild(keys[keyIndex]))
                    {
                        // has child
                        JSONNode c = new JSONNode(NodeType.Object);
                        c = node.GetAs<JSONNode>(keys[keyIndex]);
                        return GetConfigIntFromNode(keys, keyIndex + 1, c, modname, defaultvalue, key);
                    }
                    else
                    {
                        JSONNode c = new JSONNode(NodeType.Object);
                        node.SetAs<JSONNode>(keys[keyIndex], c);
                        return GetConfigIntFromNode(keys, keyIndex + 1, c, modname, defaultvalue, key);
                    }
                }
                else
                {
                    if (node.TryGetAs<int>(keys[keyIndex], out int value) == true)
                    {
                        return value;
                    }
                    node.SetAs(keys[keyIndex], defaultvalue);
                    RewriteConfig(modname);
                    return defaultvalue;
                }
            }
            catch (Exception e)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName,
                    "Error loading configuration (" + modname + "): " + key + " - " + keyIndex.ToString() + "\n" + e.Message + "\n\n" + e.StackTrace, Helpers.Logging.LogType.Issue);

                Helpers.Logging.WriteLog(modname,
                    "Error loading configuration (" + modname + "): " + key + " - " + keyIndex.ToString() + "\n" + e.Message + "\n\n" + e.StackTrace, Helpers.Logging.LogType.Issue, true, true);
                return 0;
            }
        }

        public static float GetConfigFloatOrDefault(string modname, string key, float defaultvalue)
        {
            JSONNode configNode = GetConfigDataNode(modname);

            string[] keys = key.Split('.');

            if (keys.Length > 0)
            {
                return GetConfigFloatFromNode(keys, 0, configNode, modname, defaultvalue, key);
            }
            else
            {
                float result = 0;
                if (configNode.TryGetAs<float>(key, out result) == false)
                {
                    result = defaultvalue;
                    configNode.SetAs(key, defaultvalue);
                    RewriteConfig(modname);
                }
                return result;
            }
        }

        private static float GetConfigFloatFromNode(string[] keys, int keyIndex, JSONNode node, string modname, float defaultvalue, string key)
        {
            try
            {
                if (keys.Length > 0 && keyIndex < keys.Length - 1)
                {
                    if (node.HasChild(keys[keyIndex]))
                    {
                        JSONNode c = new JSONNode(NodeType.Object);
                        c = node.GetAs<JSONNode>(keys[keyIndex]);
                        return GetConfigFloatFromNode(keys, keyIndex + 1, c, modname, defaultvalue, key);
                    }
                    else
                    {
                        JSONNode c = new JSONNode(NodeType.Object);
                        node.SetAs<JSONNode>(keys[keyIndex], c);
                        return GetConfigFloatFromNode(keys, keyIndex + 1, c, modname, defaultvalue, key);
                    }
                }
                else
                {
                    if (node.TryGetAs<float>(keys[keyIndex], out float value) == true)
                    {
                        return value;
                    }
                    node.SetAs(keys[keyIndex], defaultvalue);
                    RewriteConfig(modname);
                    return defaultvalue;
                }
            }
            catch (Exception e)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName,
                    "Error loading configuration (" + modname + "): " + key + " - " + keyIndex.ToString() + "\n" + e.Message + "\n\n" + e.StackTrace, Helpers.Logging.LogType.Issue);

                Helpers.Logging.WriteLog(modname,
                    "Error loading configuration (" + modname + "): " + key + " - " + keyIndex.ToString() + "\n" + e.Message + "\n\n" + e.StackTrace, Helpers.Logging.LogType.Issue, true, true);
                return 0f;
            }
        }

        public static JSONNode GetConfigNode(string modname, string key)
        {
            JSONNode configNode = GetConfigDataNode(modname);
            string[] keys = key.Split('.');
            if (keys.Length > 0)
            {
                return GetConfigNodeFromNode(keys, 0, configNode, modname, key);
            }
            else
            {
                return configNode.GetAs<JSONNode>(key);
            }
        }

        private static JSONNode GetConfigNodeFromNode(string[] keys, int keyIndex, JSONNode node, string modname, string key)
        {
            try
            {
                if (keys.Length > 0 && keyIndex < keys.Length - 1)
                {
                    if (node.HasChild(keys[keyIndex]))
                    {
                        JSONNode c = new JSONNode(NodeType.Object);
                        c = node.GetAs<JSONNode>(keys[keyIndex]);
                        return GetConfigNodeFromNode(keys, keyIndex + 1, c, modname, key);
                    }
                    else
                    {
                        return new JSONNode(NodeType.Array);
                    }
                }
                else
                {
                    return node.GetAs<JSONNode>(keys[keyIndex]);
                }
            }
            catch (Exception e)
            {
                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName,
                    "Error loading configuration (" + modname + "): " + key + " - " + keyIndex.ToString() + "\n" + e.Message + "\n\n" + e.StackTrace, Helpers.Logging.LogType.Issue);

                Helpers.Logging.WriteLog(modname,
                    "Error loading configuration (" + modname + "): " + key + " - " + keyIndex.ToString() + "\n" + e.Message + "\n\n" + e.StackTrace, Helpers.Logging.LogType.Issue, true, true);
                return new JSONNode(NodeType.Array);
            }
        }

        private static string GetConfigLocation(string location, string configFile)
        {
            return Helpers.Utilities.MultiCombine(location, configFile);
        }

        private static string GetWorldConfigLocation(string modname)
        {
            return Helpers.Utilities.MultiCombine(NewColonyAPIEntry.GameSaveFolder, ServerManager.WorldName, "configs", modname + ".json");
        }

        private static void RewriteConfig(string modname)
        {
            JSON.Serialize(Helpers.Utilities.MultiCombine(NewColonyAPIEntry.GameSaveFolder, ServerManager.WorldName, "configs", modname + ".json"), configsetings[modname], 99);
        }
    }
}
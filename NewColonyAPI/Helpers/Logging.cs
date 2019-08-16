using System;
using System.Collections.Generic;
using System.IO;

namespace PhentrixGames.NewColonyAPI.Helpers
{
    [ModLoader.ModManager]
    public static class Logging
    {
        private static Dictionary<string, StreamWriter> sw = new Dictionary<string, StreamWriter>();

        public enum LogType
        {
            Normal,
            Info,
            Loading,
            Issue,
            Error
        }

        internal enum LogVersionType
        {
            Newer,
            Release,
            Outofdate
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, NewColonyAPIEntry.Naming + "CreateLogs")]
        internal static void CreateLog()
        {
            foreach (string id in Mods.ModManager.GetMods().Keys)
            {
                if (id != null && id != "")
                {
                    if (sw.ContainsKey(id))
                        WriteLog(NewColonyAPIEntry.ModName, "The mod [" + id + "] has already created an errorlog!", LogType.Issue);
                    else
                    {
                        Helpers.Utilities.MakeDirectoryIfNeeded(Utilities.MultiCombine(NewColonyAPIEntry.GameSaveFolder, ServerManager.WorldName, "errorlogs"));
                        sw.Add(id, new StreamWriter(Utilities.MultiCombine(NewColonyAPIEntry.GameSaveFolder, ServerManager.WorldName, "errorlogs", id + ".txt")));
                        WriteLog(id, "Log Created!", LogType.Loading);
                    }
                }
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnQuit, NewColonyAPIEntry.Naming + "CloseLogs")]
        internal static void CloseLogs()
        {
            foreach (string s in sw.Keys)
            {
                sw[s].Dispose();
                sw[s].Close();
            }
            sw.Clear();
        }

        public static void WriteLog(string modname, string message, LogType logType, bool output = false, bool ignoreconsole = false)
        {
            Pipliz.LogMessage t = new Pipliz.LogMessage();

            switch (logType)
            {
                case LogType.Normal:
                    t = new Pipliz.LogMessage(GetTimestamp() + "[" + modname + "]:" + Chat.BuildMessage(message, Chat.ChatColour.white), UnityEngine.LogType.Log);
                    break;

                case LogType.Info:
                    t = new Pipliz.LogMessage(GetTimestamp() + "[" + modname + "]:" + Chat.BuildMessage(message, Chat.ChatColour.lime), UnityEngine.LogType.Log);
                    break;

                case LogType.Issue:
                    t = new Pipliz.LogMessage(GetTimestamp() + "[" + modname + "]:" + Chat.BuildMessage(message, Chat.ChatColour.orange), UnityEngine.LogType.Log);
                    break;

                case LogType.Loading:
                    t = new Pipliz.LogMessage(GetTimestamp() + "[" + modname + "]:" + Chat.BuildMessage(message, Chat.ChatColour.lightblue), UnityEngine.LogType.Log);
                    break;

                case LogType.Error:
                    t = new Pipliz.LogMessage(GetTimestamp() + "[" + modname + "]:" + Chat.BuildMessage(message, Chat.ChatColour.red), UnityEngine.LogType.Log);
                    ThreadManager.InvokeOnMainThread(() =>
                    {
                        UnityEngine.Application.Quit();
                    }, 5.0);
                    break;
            }
            LogMessage(modname, t, output, message, ignoreconsole);
        }

        internal static void VersionLog(string modname, LogVersionType logVersion, Version latest = null)
        {
            Pipliz.LogMessage t = new Pipliz.LogMessage();
            string message = null;
            switch (logVersion)
            {
                case LogVersionType.Newer:
                    message = "You are running a newer version than the public release (latest public release: " + latest.ToString() + ")";
                    t = new Pipliz.LogMessage(GetTimestamp() + "[" + NewColonyAPIEntry.ModName + "](Version Check): " + Chat.BuildMessage(message, Chat.ChatColour.lightblue), UnityEngine.LogType.Log);
                    break;

                case LogVersionType.Release:
                    message = ": Is up to date!";
                    t = new Pipliz.LogMessage(GetTimestamp() + "[" + NewColonyAPIEntry.ModName + "](Version Check): " + Chat.BuildMessage(message, Chat.ChatColour.green), UnityEngine.LogType.Log);
                    break;

                case LogVersionType.Outofdate:
                    message = ": Is out of date.  Latest Version: " + latest.ToString();
                    t = new Pipliz.LogMessage(GetTimestamp() + "[" + NewColonyAPIEntry.ModName + "](Version Check): " + Chat.BuildMessage(message, Chat.ChatColour.red), UnityEngine.LogType.Log);
                    break;
            }
            LogMessage(modname, t, false, message);
        }

        private static void LogMessage(string modname, Pipliz.LogMessage logMessage, bool output = false, string message = null, bool ignoreconsole = false)
        {
            if (ignoreconsole == false)
                ServerLog.LogAsyncMessage(logMessage);

            if (output && message != null)
            {
                if (sw.ContainsKey(modname))
                {
                    sw[modname].WriteLine(GetTimestamp() + message);
                    sw[modname].WriteLine("");
                    sw[modname].Flush();
                }
            }
        }

        private static string GetTimestamp()
        {
            return "[" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "]";
        }

        private static string FileName(string modname)
        {
            return DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "-" + modname + ".txt";
        }
    }
}
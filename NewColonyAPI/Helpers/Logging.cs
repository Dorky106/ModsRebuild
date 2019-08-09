using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Helpers
{
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

        internal static void CreateLog(string modName)
        {
            if(modName != null && modName != "")
            {
                if (sw.ContainsKey(modName))
                    WriteLog(NewColonyAPIEntry.ModName, "The mod [" + modName + "] has already created an errorlog!", LogType.Issue);
                else
                {
                    Helpers.Utilities.MakeDirectoryIfNeeded(Utilities.MultiCombine(NewColonyAPIEntry.GameSaveFolder, ServerManager.WorldName, "errorlogs"));
                    sw.Add(modName, new StreamWriter(Utilities.MultiCombine(NewColonyAPIEntry.GameSaveFolder, ServerManager.WorldName, "errorlogs", modName)));
                    WriteLog(modName, "Log Created!", LogType.Loading);
                }
            }
        }

        internal static void CloseLogs()
        {
            foreach (string s in sw.Keys)
            {
                sw[s].Dispose();
                sw[s].Close();
            }
            sw.Clear();
        }

        public static void WriteLog(string modname, string message, LogType logType, bool output = false)
        {
            Pipliz.LogMessage t = new Pipliz.LogMessage();

            switch (logType)
            {
                case LogType.Normal:
                    t = new Pipliz.LogMessage("Normal", UnityEngine.LogType.Log);
                    break;
                case LogType.Info:
                    t = new Pipliz.LogMessage("Info", UnityEngine.LogType.Log);
                    break;
                case LogType.Issue:
                    t = new Pipliz.LogMessage("Issue", UnityEngine.LogType.Log);
                    break;
                case LogType.Loading:
                    t = new Pipliz.LogMessage("Loading", UnityEngine.LogType.Log);
                    break;
                case LogType.Error:
                    ThreadManager.InvokeOnMainThread(() =>
                    {
                        UnityEngine.Application.Quit();
                    }, 5.0);
                    break;
            }
            LogMessage(modname, t, output, message);
        }

        private static void LogMessage(string modname, Pipliz.LogMessage logMessage, bool output = false, string message = null)
        {
            ServerLog.LogAsyncMessage(logMessage);
            if(output && message != null)
            {
                ErrorLogging(modname, message);
            }
        }

        private static void ErrorLogging(string modname, string message)
        {
            if (sw.ContainsKey(modname))
            {
                sw[modname].WriteLine(GetTimestamp() + message);
                sw[modname].WriteLine("");
                sw[modname].Flush();
            }
        }

        private static string GetTimestamp()
        {
            return "[" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "] ";
        }

        private static string FileName(string modname)
        {
            return DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + "-" + modname + ".txt";
        }
    }
}
using Pipliz.JSON;
using System;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.RotatingMessages
{
    [ModLoader.ModManager]
    internal class RotatingMessageManager
    {
        private static bool rotatorEnabled = false;
        private static Helpers.Chat.ChatColour rotatorColor = Helpers.Chat.ChatColour.white;
        private static Helpers.Chat.ChatStyle rotatorStyle = Helpers.Chat.ChatStyle.bold;

        private static int rotatorSecondsBetween = 60;
        private static List<string> rotatorMessages = new List<string>();
        private static int messageIndex = 0;
        private static long nextUpdateTime = 0;

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, NewColonyAPIEntry.Naming + "AfterSelectedWorld.RotatingMessages")]
        [ModLoader.ModCallbackDependsOn(NewColonyAPIEntry.Naming + "AfterSelectedWorld")]
        public static void Init()
        {
            if (Configuration.ConfigManager.GetConfigBooleanOrDefault(NewColonyAPIEntry.ModName, "rotatingmessages.enabled", false) == true)
            {
                rotatorEnabled = true;

                string rotatorColorConf = Configuration.ConfigManager.GetConfigStringOrDefault(NewColonyAPIEntry.ModName, "rotatingmessages.color", "yellow");
                if (Enum.IsDefined(typeof(Helpers.Chat.ChatColour), rotatorColorConf))
                {
                    rotatorColor = (Helpers.Chat.ChatColour)Enum.Parse(typeof(Helpers.Chat.ChatColour), rotatorColorConf);
                }

                string rotatorStyleConf = Configuration.ConfigManager.GetConfigStringOrDefault(NewColonyAPIEntry.ModName, "rotatingmessages.style", "bolditalic");
                if (Enum.IsDefined(typeof(Helpers.Chat.ChatColour), rotatorStyleConf))
                {
                    rotatorStyle = (Helpers.Chat.ChatStyle)Enum.Parse(typeof(Helpers.Chat.ChatStyle), rotatorStyleConf);
                }

                rotatorSecondsBetween = Configuration.ConfigManager.GetConfigIntOrDefault(NewColonyAPIEntry.ModName, "rotatingmessages.interval", 900);

                JSONNode rotatingMessagesConf = Configuration.ConfigManager.GetConfigNode(NewColonyAPIEntry.ModName, "rotatingmessages.list");
                foreach (JSONNode message in rotatingMessagesConf.LoopArray())
                {
                    rotatorMessages.Add(message.GetAs<string>());
                }

                nextUpdateTime = NextUpdate();

                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, string.Format("Rotator is enabled with {0} messages playing every {1} seconds. Next update: {2}",
                    rotatorMessages.Count,
                    rotatorSecondsBetween,
                    nextUpdateTime), Helpers.Logging.LogType.Loading);
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnFixedUpdate, NewColonyAPIEntry.Naming + "OnFixedUpdated.RotatingMessages")]
        public static void DoRun()
        {
            if (rotatorEnabled)
            {
                if (Pipliz.Time.MillisecondsSinceStart >= nextUpdateTime)
                {
                    DoRotate();
                }
            }
        }

        private static long NextUpdate()
        {
            return (long)(rotatorSecondsBetween * 1000 + Pipliz.Time.MillisecondsSinceStart);
        }

        private static void DoRotate()
        {
            Helpers.Chat.SendToAllSilent(rotatorMessages[messageIndex], rotatorColor, rotatorStyle);

            if (messageIndex < rotatorMessages.Count - 1)
            {
                messageIndex += 1;
            }
            else
            {
                messageIndex = 0;
            }

            nextUpdateTime = NextUpdate();
        }
    }
}
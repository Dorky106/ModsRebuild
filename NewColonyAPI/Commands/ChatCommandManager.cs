using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PhentrixGames.NewColonyAPI.Commands
{
    [ModLoader.ModManager]
   public static class ChatCommandManager
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
        public class NCAPICommand : Attribute { }

        private static Dictionary<string, BaseChatCommand> ChatCommandList = new Dictionary<string, BaseChatCommand>();
        public static Dictionary<string, BaseChatCommand> GetCommandlist()
        {
            return ChatCommandList;
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterSelectedWorld, NewColonyAPIEntry.Naming + "LoadCommands")]
        [ModLoader.ModCallbackDependsOn(NewColonyAPIEntry.Naming + "AfterSelectedWorld")]
        [ModLoader.ModCallbackProvidesFor("pipliz.server.registertexturemappingtextures")]
        public static void Init()
        {
            if (Configuration.ConfigManager.GetConfigBooleanOrDefault(NewColonyAPIEntry.ModName, "chat.enabled", true))
            {
                Chatting.CommandManager.RegisterCommand(new ChatCommands.Messages());
            }
            if (Configuration.ConfigManager.GetConfigBooleanOrDefault(NewColonyAPIEntry.ModName, "commands.enabled", true))
            {
                Chatting.CommandManager.RegisterCommand(new ChatCommands.MasterChatCommand());

                int count = 0;
                foreach (string modname in Mods.ModManager.GetMods().Keys)
                {
                    Mods.Mod mod = Mods.ModManager.GetMod(modname);
                    Assembly assembly = Mods.ModManager.GetAssembly(mod.ModName);
                    var typelist = assembly.GetTypes()
                        .Where(t => (t.IsClass && t.IsDefined(typeof(NCAPICommand), true)));

                    foreach (var item in typelist)
                    {
                        try
                        {
                            BaseChatCommand command = ((BaseChatCommand)Activator.CreateInstance(item));
                            if (ChatCommandList.ContainsKey(command.ChatCommandPrefix) == false)
                            {
                                ChatCommandList.Add(command.ChatCommandPrefix, command);
                                count++;
                            }
                            else
                            {
                                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "command: " + command.ChatCommandPrefix + " already exists!", Helpers.Logging.LogType.Info);
                            }
                        }
                        catch (MissingMethodException mme)
                        {
                            Helpers.Logging.WriteLog(modname, item.Name + " cannot be instantiated.  This probably is not an error.\n" + mme.Message, Helpers.Logging.LogType.Issue);
                        }
                        catch (InvalidCastException ice)
                        {
                            Helpers.Logging.WriteLog(modname, item.Name + " doesn't use our command system. This probably isn't an error.\n" + ice.Message, Helpers.Logging.LogType.Issue);
                        }
                        catch (Exception e)
                        {
                            Helpers.Logging.WriteLog(modname, item.Name + " Command Error.\n" + e.Message + "\n" + e.StackTrace, Helpers.Logging.LogType.Issue);
                        }
                    }
                }

                Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, string.Format("Autoloaded {0} commands", count), Helpers.Logging.LogType.Loading);
            }
        }
   }
}

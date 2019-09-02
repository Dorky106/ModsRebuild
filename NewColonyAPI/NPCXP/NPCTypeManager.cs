using Pipliz.JSON;
using System.Collections.Generic;
using System.IO;

namespace PhentrixGames.NewColonyAPI.NPCXP
{
    public static class NPCTypeManager
    {
        private static List<string> keynames = new List<string>();

        public static void RegisterNPCTypes(string modname, string modfolder)
        {
            string[] directories = Directory.GetDirectories(modfolder, "*", SearchOption.AllDirectories);
            foreach (string dir in directories)
            {
                if (dir.EndsWith("npcTypes"))
                {
                    string[] files = Directory.GetFiles(dir);
                    foreach (string file in files)
                    {
                        if (JSON.Deserialize(file, out JSONNode root))
                        {
                            foreach (var item in root.LoopArray())
                            {
                                if (keynames.Contains(item.GetAs<string>("keyName")) == false)
                                {
                                    keynames.Add(item.GetAs<string>("keyName"));
                                    NPC.NPCType.QueuePatch(item, 0);
                                }
                            }
                        }
                    }

                    break;
                }
            }
        }

        internal static void AddKeyname(string keyname)
        {
            if (keynames.Contains(keyname) == false)
            {
                keynames.Add(keyname);
            }
        }

        internal static List<string> GetKeys()
        {
            return keynames;
        }
    }
}
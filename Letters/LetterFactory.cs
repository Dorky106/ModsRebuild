using PhentrixGames.NewColonyAPI.Configuration;
using Pipliz.JSON;

namespace PhentrixGames.Letters
{
    public class LetterFactory
    {
        private static string[] letters = new string[]
{
                "a","b","c","d","e",
                "f","g","h","i","j",
                "k","l","m","n","o",
                "p","q","r","s","t",
                "u","v","w","x","y","z"
};

        public static void InitBlocks()
        {
            foreach (string letter in letters)
            {
                JSONNode colornode = ConfigManager.GetConfigNode(Entry.ModName, letter + ".colours");
                if (colornode != null && colornode.ChildCount != 0)
                {
                    foreach (var item in colornode.LoopArray())
                    {
                        string colour = item.GetAs<string>();

                        #region Unlit

                        BaseItem baseItem = new BaseItem(letter + colour, letter, colour, BaseItem.Rotation.Base, false);
                        ItemTypesServer.QueueItemTypePatch(baseItem.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, baseItem.Register(), 1000000);

                        BaseItem baseItemxminus = new BaseItem(letter + colour, letter, colour, BaseItem.Rotation.XMinus, false);
                        ItemTypesServer.QueueItemTypePatch(baseItemxminus.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, baseItemxminus.Register(), 1000000);

                        BaseItem baseItemxplus = new BaseItem(letter + colour, letter, colour, BaseItem.Rotation.XPlus, false);
                        ItemTypesServer.QueueItemTypePatch(baseItemxplus.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, baseItemxplus.Register(), 1000000);

                        BaseItem baseItemzminus = new BaseItem(letter + colour, letter, colour, BaseItem.Rotation.ZMinus, false);
                        ItemTypesServer.QueueItemTypePatch(baseItemzminus.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, baseItemzminus.Register(), 1000000);

                        BaseItem baseItemzplus = new BaseItem(letter + colour, letter, colour, BaseItem.Rotation.ZPlus, false);
                        ItemTypesServer.QueueItemTypePatch(baseItemzplus.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, baseItemzplus.Register(), 1000000);

                        #endregion Unlit

                        #region lit

                        BaseItem baseItemLit = new BaseItem(letter + colour, letter, colour, BaseItem.Rotation.Base, true);
                        ItemTypesServer.QueueItemTypePatch(baseItemLit.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, baseItemLit.Register(), 1000000);

                        BaseItem baseItemLitxminus = new BaseItem(letter + colour, letter, colour, BaseItem.Rotation.XMinus, true);
                        ItemTypesServer.QueueItemTypePatch(baseItemLitxminus.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, baseItemLitxminus.Register(), 1000000);

                        BaseItem baseItemLitxplus = new BaseItem(letter + colour, letter, colour, BaseItem.Rotation.XPlus, true);
                        ItemTypesServer.QueueItemTypePatch(baseItemLitxplus.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, baseItemLitxplus.Register(), 1000000);

                        BaseItem baseItemLitzminus = new BaseItem(letter + colour, letter, colour, BaseItem.Rotation.ZMinus, true);
                        ItemTypesServer.QueueItemTypePatch(baseItemLitzminus.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, baseItemLitzminus.Register(), 1000000);

                        BaseItem baseItemLitzplus = new BaseItem(letter + colour, letter, colour, BaseItem.Rotation.ZPlus, true);
                        ItemTypesServer.QueueItemTypePatch(baseItemLitzplus.TypeName, ItemTypesServer.EItemTypePatchType.AddNewTypes, baseItemLitzplus.Register(), 1000000);

                        #endregion lit
                    }
                }
            }
        }

        public static void InitRecipes()
        {
            foreach (string letter in letters)
            {
                JSONNode colornode = ConfigManager.GetConfigNode(Entry.ModName, letter + ".colours");
                if (colornode != null && colornode.ChildCount != 0)
                {
                    foreach (var item in colornode.LoopArray())
                    {
                        string colour = item.GetAs<string>();
                        BaseRecipe baseRecipe = new BaseRecipe(letter + colour);
                        baseRecipe.RegisterRecipe();
                        BaseRecipe baseRecipeLit = new BaseRecipe(letter + colour + "lit");
                        baseRecipeLit.RegisterRecipe();
                    }
                }
            }
        }
    }
}
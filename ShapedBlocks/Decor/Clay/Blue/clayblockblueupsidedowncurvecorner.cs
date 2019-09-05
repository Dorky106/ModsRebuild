using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblueupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockblueupsidedowncurvecornerRecipe() : base("clayblockblueupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblueupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedowncurvecorner : DecorativeType
    {
        public clayblockblueupsidedowncurvecorner() : base("clayblockblue", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblueupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockblue";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblueupsidedowncurvecornerXMinus() : base("clayblockblue", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblueupsidedowncurvecornerXPlus() : base("clayblockblue", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblueupsidedowncurvecornerZMinus() : base("clayblockblue", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblueupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblueupsidedowncurvecornerZPlus() : base("clayblockblue", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
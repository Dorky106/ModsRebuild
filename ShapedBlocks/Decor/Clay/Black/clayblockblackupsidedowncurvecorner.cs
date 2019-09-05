using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockblackupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockblackupsidedowncurvecornerRecipe() : base("clayblockblackupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockblackupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedowncurvecorner : DecorativeType
    {
        public clayblockblackupsidedowncurvecorner() : base("clayblockblack", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockblackupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockblack";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockblackupsidedowncurvecornerXMinus() : base("clayblockblack", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockblackupsidedowncurvecornerXPlus() : base("clayblockblack", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockblackupsidedowncurvecornerZMinus() : base("clayblockblack", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockblackupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockblackupsidedowncurvecornerZPlus() : base("clayblockblack", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
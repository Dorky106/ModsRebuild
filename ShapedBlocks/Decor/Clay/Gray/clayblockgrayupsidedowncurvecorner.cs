using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgrayupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockgrayupsidedowncurvecornerRecipe() : base("clayblockgrayupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgrayupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedowncurvecorner : DecorativeType
    {
        public clayblockgrayupsidedowncurvecorner() : base("clayblockgray", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgrayupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockgray";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgrayupsidedowncurvecornerXMinus() : base("clayblockgray", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgrayupsidedowncurvecornerXPlus() : base("clayblockgray", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgrayupsidedowncurvecornerZMinus() : base("clayblockgray", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgrayupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgrayupsidedowncurvecornerZPlus() : base("clayblockgray", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
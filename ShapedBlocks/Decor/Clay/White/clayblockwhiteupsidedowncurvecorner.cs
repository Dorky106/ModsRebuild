using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockwhiteupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockwhiteupsidedowncurvecornerRecipe() : base("clayblockwhiteupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockwhiteupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedowncurvecorner : DecorativeType
    {
        public clayblockwhiteupsidedowncurvecorner() : base("clayblockwhite", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockwhiteupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockwhite";
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockwhiteupsidedowncurvecornerXMinus() : base("clayblockwhite", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockwhiteupsidedowncurvecornerXPlus() : base("clayblockwhite", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockwhiteupsidedowncurvecornerZMinus() : base("clayblockwhite", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockwhiteupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockwhiteupsidedowncurvecornerZPlus() : base("clayblockwhite", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockgreenupsidedownslopecornerRecipe() : base("clayblockgreenupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopecorner : DecorativeType
    {
        public clayblockgreenupsidedownslopecorner() : base("clayblockgreen", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenupsidedownslopecornerXMinus() : base("clayblockgreen", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenupsidedownslopecornerXPlus() : base("clayblockgreen", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenupsidedownslopecornerZMinus() : base("clayblockgreen", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenupsidedownslopecornerZPlus() : base("clayblockgreen", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}
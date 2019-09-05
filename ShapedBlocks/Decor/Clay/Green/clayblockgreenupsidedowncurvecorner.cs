using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockgreenupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockgreenupsidedowncurvecornerRecipe() : base("clayblockgreenupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockgreenupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedowncurvecorner : DecorativeType
    {
        public clayblockgreenupsidedowncurvecorner() : base("clayblockgreen", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockgreenupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockgreen";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockgreenupsidedowncurvecornerXMinus() : base("clayblockgreen", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockgreenupsidedowncurvecornerXPlus() : base("clayblockgreen", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockgreenupsidedowncurvecornerZMinus() : base("clayblockgreen", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockgreenupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockgreenupsidedowncurvecornerZPlus() : base("clayblockgreen", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
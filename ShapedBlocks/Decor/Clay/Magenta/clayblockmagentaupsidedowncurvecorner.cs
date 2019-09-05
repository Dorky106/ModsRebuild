using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockmagentaupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockmagentaupsidedowncurvecornerRecipe() : base("clayblockmagentaupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockmagentaupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedowncurvecorner : DecorativeType
    {
        public clayblockmagentaupsidedowncurvecorner() : base("clayblockmagenta", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockmagentaupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockmagenta";
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockmagentaupsidedowncurvecornerXMinus() : base("clayblockmagenta", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockmagentaupsidedowncurvecornerXPlus() : base("clayblockmagenta", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockmagentaupsidedowncurvecornerZMinus() : base("clayblockmagenta", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockmagentaupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockmagentaupsidedowncurvecornerZPlus() : base("clayblockmagenta", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
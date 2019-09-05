using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpinkupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockpinkupsidedowncurvecornerRecipe() : base("clayblockpinkupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpinkupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedowncurvecorner : DecorativeType
    {
        public clayblockpinkupsidedowncurvecorner() : base("clayblockpink", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpinkupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockpink";
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpinkupsidedowncurvecornerXMinus() : base("clayblockpink", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpinkupsidedowncurvecornerXPlus() : base("clayblockpink", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpinkupsidedowncurvecornerZMinus() : base("clayblockpink", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpinkupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpinkupsidedowncurvecornerZPlus() : base("clayblockpink", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
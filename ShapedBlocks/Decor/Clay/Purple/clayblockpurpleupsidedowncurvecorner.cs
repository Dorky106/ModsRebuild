using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockpurpleupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockpurpleupsidedowncurvecornerRecipe() : base("clayblockpurpleupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockpurpleupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedowncurvecorner : DecorativeType
    {
        public clayblockpurpleupsidedowncurvecorner() : base("clayblockpurple", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockpurpleupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockpurple";
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockpurpleupsidedowncurvecornerXMinus() : base("clayblockpurple", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockpurpleupsidedowncurvecornerXPlus() : base("clayblockpurple", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockpurpleupsidedowncurvecornerZMinus() : base("clayblockpurple", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockpurpleupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockpurpleupsidedowncurvecornerZPlus() : base("clayblockpurple", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
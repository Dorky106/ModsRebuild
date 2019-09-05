using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockupsidedowncurvecornerRecipe() : base("clayblockupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockupsidedowncurvecorner : DecorativeType
    {
        public clayblockupsidedowncurvecorner() : base("clayblock", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblock";
        }
    }

    [NCAPIType]
    public class clayblockupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockupsidedowncurvecornerXMinus() : base("clayblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockupsidedowncurvecornerXPlus() : base("clayblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockupsidedowncurvecornerZMinus() : base("clayblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockupsidedowncurvecornerZPlus() : base("clayblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilvercurvecornerRecipe : BaseRecipe
    {
        public clayblocksilvercurvecornerRecipe() : base("clayblocksilvercurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilvercurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilvercurvecorner : DecorativeType
    {
        public clayblocksilvercurvecorner() : base("clayblocksilver", "curvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilvercurvecorner.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilvercurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocksilvercurvecornerXMinus() : base("clayblocksilver", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocksilvercurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocksilvercurvecornerXPlus() : base("clayblocksilver", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocksilvercurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocksilvercurvecornerZMinus() : base("clayblocksilver", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocksilvercurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocksilvercurvecornerZPlus() : base("clayblocksilver", "curvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("curvecornerz+");
        }
    }
}
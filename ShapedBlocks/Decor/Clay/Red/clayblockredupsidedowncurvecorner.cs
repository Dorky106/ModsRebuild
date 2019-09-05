using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockredupsidedowncurvecornerRecipe() : base("clayblockredupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockredupsidedowncurvecorner : DecorativeType
    {
        public clayblockredupsidedowncurvecorner() : base("clayblockred", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockredupsidedowncurvecornerXMinus() : base("clayblockred", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockredupsidedowncurvecornerXPlus() : base("clayblockred", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockredupsidedowncurvecornerZMinus() : base("clayblockred", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockredupsidedowncurvecornerZPlus() : base("clayblockred", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
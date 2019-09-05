using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockredupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblockredupsidedownslopecornerRecipe() : base("clayblockredupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockredupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopecorner : DecorativeType
    {
        public clayblockredupsidedownslopecorner() : base("clayblockred", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockredupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockred";
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockredupsidedownslopecornerXMinus() : base("clayblockred", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockredupsidedownslopecornerXPlus() : base("clayblockred", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockredupsidedownslopecornerZMinus() : base("clayblockred", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockredupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockredupsidedownslopecornerZPlus() : base("clayblockred", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}
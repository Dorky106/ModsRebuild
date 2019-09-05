using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimeupsidedownslopeinsidecornerRecipe : BaseRecipe
    {
        public clayblocklimeupsidedownslopeinsidecornerRecipe() : base("clayblocklimeupsidedownslopeinsidecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimeupsidedownslopeinsidecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopeinsidecorner : DecorativeType
    {
        public clayblocklimeupsidedownslopeinsidecorner() : base("clayblocklime", "upsidedownslopeinsidecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimeupsidedownslopeinsidecorner.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopeinsidecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklimeupsidedownslopeinsidecornerXMinus() : base("clayblocklime", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopeinsidecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklimeupsidedownslopeinsidecornerXPlus() : base("clayblocklime", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopeinsidecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklimeupsidedownslopeinsidecornerZMinus() : base("clayblocklime", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopeinsidecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklimeupsidedownslopeinsidecornerZPlus() : base("clayblocklime", "upsidedownslopeinsidecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopeinsidecornerz+");
        }
    }
}
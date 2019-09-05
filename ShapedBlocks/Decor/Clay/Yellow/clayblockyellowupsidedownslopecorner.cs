using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblockyellowupsidedownslopecornerRecipe : BaseRecipe
    {
        public ClayblockyellowupsidedownslopecornerRecipe() : base("clayblockyellowupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class Clayblockyellowupsidedownslopecorner : DecorativeType
    {
        public Clayblockyellowupsidedownslopecorner() : base("clayblockyellow", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowupsidedownslopecornerXMinus() : base("clayblockyellow", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowupsidedownslopecornerXPlus() : base("clayblockyellow", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowupsidedownslopecornerZMinus() : base("clayblockyellow", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowupsidedownslopecornerZPlus() : base("clayblockyellow", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}
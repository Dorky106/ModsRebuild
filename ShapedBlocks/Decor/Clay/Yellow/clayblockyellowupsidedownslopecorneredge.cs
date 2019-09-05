using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class ClayblockyellowupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public ClayblockyellowupsidedownslopecorneredgeRecipe() : base("clayblockyellowupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class Clayblockyellowupsidedownslopecorneredge : DecorativeType
    {
        public Clayblockyellowupsidedownslopecorneredge() : base("clayblockyellow", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowupsidedownslopecorneredgeXMinus() : base("clayblockyellow", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowupsidedownslopecorneredgeXPlus() : base("clayblockyellow", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowupsidedownslopecorneredgeZMinus() : base("clayblockyellow", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowupsidedownslopecorneredgeZPlus() : base("clayblockyellow", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}
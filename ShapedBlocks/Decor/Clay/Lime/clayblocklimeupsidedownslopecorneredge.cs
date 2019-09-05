using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimeupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblocklimeupsidedownslopecorneredgeRecipe() : base("clayblocklimeupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimeupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopecorneredge : DecorativeType
    {
        public clayblocklimeupsidedownslopecorneredge() : base("clayblocklime", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimeupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblocklimeupsidedownslopecorneredgeXMinus() : base("clayblocklime", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblocklimeupsidedownslopecorneredgeXPlus() : base("clayblocklime", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblocklimeupsidedownslopecorneredgeZMinus() : base("clayblocklime", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblocklimeupsidedownslopecorneredgeZPlus() : base("clayblocklime", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}
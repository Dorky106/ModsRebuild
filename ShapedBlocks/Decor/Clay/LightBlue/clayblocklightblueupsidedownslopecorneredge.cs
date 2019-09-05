using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightblueupsidedownslopecorneredgeRecipe : BaseRecipe
    {
        public clayblocklightblueupsidedownslopecorneredgeRecipe() : base("clayblocklightblueupsidedownslopecorneredgerecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightblueupsidedownslopecorneredge", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopecorneredge : DecorativeType
    {
        public clayblocklightblueupsidedownslopecorneredge() : base("clayblocklightblue", "upsidedownslopecorneredge",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightblueupsidedownslopecorneredge.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopecorneredgeXMinus : DecorativeTypeXMinus
    {
        public clayblocklightblueupsidedownslopecorneredgeXMinus() : base("clayblocklightblue", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopecorneredgeXPlus : DecorativeTypeXPlus
    {
        public clayblocklightblueupsidedownslopecorneredgeXPlus() : base("clayblocklightblue", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgex+");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopecorneredgeZMinus : DecorativeTypeZMinus
    {
        public clayblocklightblueupsidedownslopecorneredgeZMinus() : base("clayblocklightblue", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedownslopecorneredgeZPlus : DecorativeTypeZPlus
    {
        public clayblocklightblueupsidedownslopecorneredgeZPlus() : base("clayblocklightblue", "upsidedownslopecorneredge", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecorneredgez+");
        }
    }
}
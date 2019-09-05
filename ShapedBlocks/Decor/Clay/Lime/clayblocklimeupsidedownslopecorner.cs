using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimeupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblocklimeupsidedownslopecornerRecipe() : base("clayblocklimeupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimeupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopecorner : DecorativeType
    {
        public clayblocklimeupsidedownslopecorner() : base("clayblocklime", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimeupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklimeupsidedownslopecornerXMinus() : base("clayblocklime", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklimeupsidedownslopecornerXPlus() : base("clayblocklime", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklimeupsidedownslopecornerZMinus() : base("clayblocklime", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklimeupsidedownslopecornerZPlus() : base("clayblocklime", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}
using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockorangeupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockorangeupsidedowncurvecornerRecipe() : base("clayblockorangeupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockorangeupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedowncurvecorner : DecorativeType
    {
        public clayblockorangeupsidedowncurvecorner() : base("clayblockorange", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockorangeupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockorange";
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockorangeupsidedowncurvecornerXMinus() : base("clayblockorange", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockorangeupsidedowncurvecornerXPlus() : base("clayblockorange", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockorangeupsidedowncurvecornerZMinus() : base("clayblockorange", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockorangeupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockorangeupsidedowncurvecornerZPlus() : base("clayblockorange", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
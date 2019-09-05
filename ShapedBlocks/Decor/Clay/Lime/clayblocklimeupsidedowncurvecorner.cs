using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklimeupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblocklimeupsidedowncurvecornerRecipe() : base("clayblocklimeupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklimeupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedowncurvecorner : DecorativeType
    {
        public clayblocklimeupsidedowncurvecorner() : base("clayblocklime", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklimeupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblocklime";
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklimeupsidedowncurvecornerXMinus() : base("clayblocklime", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklimeupsidedowncurvecornerXPlus() : base("clayblocklime", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklimeupsidedowncurvecornerZMinus() : base("clayblocklime", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklimeupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklimeupsidedowncurvecornerZPlus() : base("clayblocklime", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
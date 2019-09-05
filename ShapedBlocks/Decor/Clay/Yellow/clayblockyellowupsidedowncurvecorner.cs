using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockyellowupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockyellowupsidedowncurvecornerRecipe() : base("clayblockyellowupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockyellowupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedowncurvecorner : DecorativeType
    {
        public clayblockyellowupsidedowncurvecorner() : base("clayblockyellow", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockyellowupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockyellow";
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockyellowupsidedowncurvecornerXMinus() : base("clayblockyellow", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockyellowupsidedowncurvecornerXPlus() : base("clayblockyellow", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockyellowupsidedowncurvecornerZMinus() : base("clayblockyellow", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockyellowupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockyellowupsidedowncurvecornerZPlus() : base("clayblockyellow", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
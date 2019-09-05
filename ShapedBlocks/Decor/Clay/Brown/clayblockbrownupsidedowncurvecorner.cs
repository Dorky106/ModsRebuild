using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblockbrownupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblockbrownupsidedowncurvecornerRecipe() : base("clayblockbrownupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblockbrownupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedowncurvecorner : DecorativeType
    {
        public clayblockbrownupsidedowncurvecorner() : base("clayblockbrown", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblockbrownupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblockbrown";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblockbrownupsidedowncurvecornerXMinus() : base("clayblockbrown", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblockbrownupsidedowncurvecornerXPlus() : base("clayblockbrown", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblockbrownupsidedowncurvecornerZMinus() : base("clayblockbrown", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblockbrownupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblockbrownupsidedowncurvecornerZPlus() : base("clayblockbrown", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
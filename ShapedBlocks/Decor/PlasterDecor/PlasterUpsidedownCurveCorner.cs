using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockupsidedowncurvecornerRecipe : BaseRecipe
    {
        public plasterblockupsidedowncurvecornerRecipe() : base("plasterblockupsidedowncurvecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class plasterblockupsidedowncurvecorner : DecorativeType
    {
        public plasterblockupsidedowncurvecorner() : base("plasterblock", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockupsidedowncurvecorner.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public plasterblockupsidedowncurvecornerXMinus() : base("plasterblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public plasterblockupsidedowncurvecornerXPlus() : base("plasterblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public plasterblockupsidedowncurvecornerZMinus() : base("plasterblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public plasterblockupsidedowncurvecornerZPlus() : base("plasterblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
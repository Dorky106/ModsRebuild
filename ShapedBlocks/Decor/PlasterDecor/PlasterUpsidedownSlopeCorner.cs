using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class plasterblockupsidedownslopecornerRecipe : BaseRecipe
    {
        public plasterblockupsidedownslopecornerRecipe() : base("plasterblockupsidedownslopecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("plasterblock", 1));
            Result.Add(new InventoryItem("plasterblockupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopecorner : DecorativeType
    {
        public plasterblockupsidedownslopecorner() : base("plasterblock", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "plasterblockupsidedownslopecorner.png"))
        {
            this.SideAll = "plasterblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public plasterblockupsidedownslopecornerXMinus() : base("plasterblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public plasterblockupsidedownslopecornerXPlus() : base("plasterblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public plasterblockupsidedownslopecornerZMinus() : base("plasterblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class plasterblockupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public plasterblockupsidedownslopecornerZPlus() : base("plasterblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}
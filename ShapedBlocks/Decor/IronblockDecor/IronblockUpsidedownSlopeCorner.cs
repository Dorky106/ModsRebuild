using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockupsidedownslopecornerRecipe : BaseRecipe
    {
        public IronblockupsidedownslopecornerRecipe() : base("ironblockupsidedownslopecornerrecipe", "phentrixgames.woodcarver", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class Ironblockupsidedownslopecorner : DecorativeType
    {
        public Ironblockupsidedownslopecorner() : base("ironblock", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockupsidedownslopecorner.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public ironblockupsidedownslopecornerXMinus() : base("ironblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public ironblockupsidedownslopecornerXPlus() : base("ironblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public ironblockupsidedownslopecornerZMinus() : base("ironblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public ironblockupsidedownslopecornerZPlus() : base("ironblock", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}
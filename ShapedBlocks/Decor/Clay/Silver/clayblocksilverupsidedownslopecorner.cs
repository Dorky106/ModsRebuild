using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilverupsidedownslopecornerRecipe : BaseRecipe
    {
        public clayblocksilverupsidedownslopecornerRecipe() : base("clayblocksilverupsidedownslopecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverupsidedownslopecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopecorner : DecorativeType
    {
        public clayblocksilverupsidedownslopecorner() : base("clayblocksilver", "upsidedownslopecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverupsidedownslopecorner.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverupsidedownslopecornerXMinus() : base("clayblocksilver", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverupsidedownslopecornerXPlus() : base("clayblocksilver", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverupsidedownslopecornerZMinus() : base("clayblocksilver", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedownslopecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverupsidedownslopecornerZPlus() : base("clayblocksilver", "upsidedownslopecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedownslopecornerz+");
        }
    }
}
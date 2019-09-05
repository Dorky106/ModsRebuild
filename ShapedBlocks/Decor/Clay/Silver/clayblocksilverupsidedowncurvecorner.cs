using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocksilverupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblocksilverupsidedowncurvecornerRecipe() : base("clayblocksilverupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocksilverupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedowncurvecorner : DecorativeType
    {
        public clayblocksilverupsidedowncurvecorner() : base("clayblocksilver", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocksilverupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblocksilver";
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocksilverupsidedowncurvecornerXMinus() : base("clayblocksilver", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocksilverupsidedowncurvecornerXPlus() : base("clayblocksilver", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocksilverupsidedowncurvecornerZMinus() : base("clayblocksilver", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocksilverupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocksilverupsidedowncurvecornerZPlus() : base("clayblocksilver", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
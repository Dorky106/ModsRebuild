using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class IronblockupsidedowncurvecornerRecipe : BaseRecipe
    {
        public IronblockupsidedowncurvecornerRecipe() : base("ironblockupsidedowncurvecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironblock", 1));
            Result.Add(new InventoryItem("ironblockupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class Ironblockupsidedowncurvecorner : DecorativeType
    {
        public Ironblockupsidedowncurvecorner() : base("ironblock", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "ironblockupsidedowncurvecorner.png"))
        {
            this.SideAll = "ironblock";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class ironblockupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public ironblockupsidedowncurvecornerXMinus() : base("ironblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public ironblockupsidedowncurvecornerXPlus() : base("ironblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class ironblockupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public ironblockupsidedowncurvecornerZMinus() : base("ironblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class ironblockupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public ironblockupsidedowncurvecornerZPlus() : base("ironblock", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
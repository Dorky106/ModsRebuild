using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class stonebricksupsidedowncurvecornerRecipe : BaseRecipe
    {
        public stonebricksupsidedowncurvecornerRecipe() : base("stonebricksupsidedowncurvecornerrecipe", "phentrixgames.woodcarver", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1));
            Result.Add(new InventoryItem("stonebricksupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class stonebricksupsidedowncurvecorner : DecorativeType
    {
        public stonebricksupsidedowncurvecorner() : base("stonebricks", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "stonebricksupsidedowncurvecorner.png"))
        {
            this.SideAll = "stonebricks";
            this.Categories = new System.Collections.Generic.List<string> { "decorative" };
        }
    }

    [NCAPIType]
    public class stonebricksupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public stonebricksupsidedowncurvecornerXMinus() : base("stonebricks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public stonebricksupsidedowncurvecornerXPlus() : base("stonebricks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public stonebricksupsidedowncurvecornerZMinus() : base("stonebricks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class stonebricksupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public stonebricksupsidedowncurvecornerZPlus() : base("stonebricks", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
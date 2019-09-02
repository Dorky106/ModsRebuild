using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Textures;
using PhentrixGames.NewColonyAPI.Types;
using System.Collections.Generic;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.RiseoftheNewColonies.NewBlocks
{
    [NCAPITexture]
    public class ConcreteTexture : BaseTexture
    {
        public ConcreteTexture() : base("Concrete",
            NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "albedo", "concrete.png"),
            null,
            NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "height", "concrete.png"),
            NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "normal", "concrete.png"))
        { }
    }

    [NCAPIRecipe]
    public class WhiteConcreteRecipe : BaseRecipe
    {
        public WhiteConcreteRecipe() : base("WhiteConcreteRecipe", "pipliz.crafter", false, 10, 0)
        {
            this.Requirements = new List<InventoryItem>()
            {
                new InventoryItem("stonebricks"),
                new InventoryItem("bucketwater")
            };

            this.Result = new List<InventoryItem>()
            {
                new InventoryItem("whiteconcrete"),
                new InventoryItem("bucketempty")
            };
        }
    }

    [NCAPIType]
    public class WhiteConcrete : BaseType
    {
        public WhiteConcrete() : base("whiteconcrete", false)
        {
            this.SideAll = "Concrete";
            this.IsPlaceable = true;
            this.Colors = new string[] { "#ff0000->#ffffff" };
            this.Color = "#ffffff";
            this.UseHeightMap = true;
            this.UseNormalMap = true;
            this.Categories = new List<string> { "decorative" };
        }
    }

    [NCAPIRecipe]
    public class LightGreyConcreteRecipe : BaseRecipe
    {
        public LightGreyConcreteRecipe() : base("LightGreyConcreteRecipe", "pipliz.crafter", false, 10, 0)
        {
            this.Requirements = new List<InventoryItem>()
            {
                new InventoryItem("stonebricks"),
                new InventoryItem("bucketwater")
            };

            this.Result = new List<InventoryItem>()
            {
                new InventoryItem("lightgreyconcrete"),
                new InventoryItem("bucketempty")
            };
        }
    }

    [NCAPIType]
    public class LightGreyConcrete : BaseType
    {
        public LightGreyConcrete() : base("lightgreyconcrete", false)
        {
            this.SideAll = "Concrete";
            this.IsPlaceable = true;
            this.Colors = new string[] { "#ff0000->#d3d3d3" };
            this.Color = "#d3d3d3";
            this.UseHeightMap = true;
            this.UseNormalMap = true;
            this.Categories = new List<string> { "decorative" };
        }
    }

    [NCAPIRecipe]
    public class GreyConcreteRecipe : BaseRecipe
    {
        public GreyConcreteRecipe() : base("GreyConcreteRecipe", "pipliz.crafter", false, 10, 0)
        {
            this.Requirements = new List<InventoryItem>()
            {
                new InventoryItem("stonebricks"),
                new InventoryItem("bucketwater")
            };

            this.Result = new List<InventoryItem>()
            {
                new InventoryItem("greyconcrete"),
                new InventoryItem("bucketempty")
            };
        }
    }

    [NCAPIType]
    public class GreyConcrete : BaseType
    {
        public GreyConcrete() : base("greyconcrete", false)
        {
            this.SideAll = "Concrete";
            this.IsPlaceable = true;
            this.Colors = new string[] { "#ff0000->#a9a9a9" };
            this.Color = "#a9a9a9";
            this.UseHeightMap = true;
            this.UseNormalMap = true;
            this.Categories = new List<string> { "decorative" };
        }
    }

    [NCAPIRecipe]
    public class DarkGreyConcreteRecipe : BaseRecipe
    {
        public DarkGreyConcreteRecipe() : base("DarkGreyConcreteRecipe", "pipliz.crafter", false, 10, 0)
        {
            this.Requirements = new List<InventoryItem>()
            {
                new InventoryItem("stonebricks"),
                new InventoryItem("bucketwater")
            };

            this.Result = new List<InventoryItem>()
            {
                new InventoryItem("darkgreyconcrete"),
                new InventoryItem("bucketempty")
            };
        }
    }

    [NCAPIType]
    public class DarkGreyConcrete : BaseType
    {
        public DarkGreyConcrete() : base("darkgreyconcrete", false)
        {
            this.SideAll = "Concrete";
            this.IsPlaceable = true;
            this.Colors = new string[] { "#ff0000->#696969" };
            this.Color = "#696969";
            this.UseHeightMap = true;
            this.UseNormalMap = true;
            this.Categories = new List<string> { "decorative" };
        }
    }
}
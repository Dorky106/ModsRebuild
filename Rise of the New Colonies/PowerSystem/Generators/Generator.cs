using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Power;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using System.Collections.Generic;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.PowerSystem.Generators
{
    [NCAPIPowerRecipe]
    public class GeneratorRecipe : BaseRecipe
    {
        public GeneratorRecipe() : base("GeneratorRecipe")
        {
            this.Requirements = new List<InventoryItem>
            {
                new InventoryItem("copper", 50)
            };

            this.Result = new List<InventoryItem>
            {
                new InventoryItem("Generator")
            };
        }
    }

    [NCAPIPowerType]
    public class GeneratorBlock : BaseType
    {
        public GeneratorBlock() : base("Generator", false)
        {
            this.IsPlaceable = true;
            this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, "generator.png");
            if (MeshManager.GetMesh(Entry.ModName, "generator", out string mesh))
            {
                this.Mesh = mesh;
            }
            this.IsRotatable = true;
            this.RotatableXMinus = this.TypeName + "X-";
            this.RotatableXPlus = this.TypeName + "X+";
            this.RotatableZMinus = this.TypeName + "Z-";
            this.RotatableZPlus = this.TypeName + "Z+";
            PowerManager.ValidateBlockID(this.TypeName, new BasicGenerator());
        }
    }

    [NCAPIPowerType]
    public class GeneratorXPlus : BaseType
    {
        public GeneratorXPlus() : base("GeneratorX+", false)
        {
            this.ParentType = "Generator";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 0, 0);
            PowerManager.ValidateBlockID(this.TypeName, new BasicGenerator());
        }
    }

    [NCAPIPowerType]
    public class BasicBlockXMinus : BaseType
    {
        public BasicBlockXMinus() : base("GeneratorX-", false)
        {
            this.ParentType = "Generator";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 180, 0);
            PowerManager.ValidateBlockID(this.TypeName, new BasicGenerator());
        }
    }

    [NCAPIPowerType]
    public class GeneratorZPlus : BaseType
    {
        public GeneratorZPlus() : base("GeneratorZ+", false)
        {
            this.ParentType = "Generator";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 270, 0);
            PowerManager.ValidateBlockID(this.TypeName, new BasicGenerator());
        }
    }

    [NCAPIPowerType]
    public class GeneratorZMinus : BaseType
    {
        public GeneratorZMinus() : base("GeneratorZ-", false)
        {
            this.ParentType = "Generator";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 90, 0);
            PowerManager.ValidateBlockID(this.TypeName, new BasicGenerator());
        }
    }

    [NCAPIPowerType]
    public class GeneratorBlockLit : BaseType
    {
        public GeneratorBlockLit() : base("GeneratorLit", false)
        {
            this.IsPlaceable = true;
            this.IsRotatable = true;
            this.RotatableXMinus = "GeneratorLitX-";
            this.RotatableXPlus = "GeneratorLitX+";
            this.RotatableZMinus = "GeneratorLitZ-";
            this.RotatableZPlus = "GeneratorLitZ+";
            if (MeshManager.GetMesh(Entry.ModName, "generator", out string mesh))
            {
                this.Mesh = mesh;
            }
            PowerManager.ValidateBlockID(this.TypeName, new BasicGenerator());
            this.OnRemove = new ItemTypes.ItemTypeRawDrops[] { new ItemTypes.ItemTypeRawDrops("Generator", 1, 1) };
        }
    }

    [NCAPIPowerType]
    public class GeneratorBlockLitXPlus : BaseType
    {
        public GeneratorBlockLitXPlus() : base("GeneratorLitX+", false)
        {
            this.ParentType = "GeneratorLit";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 0, 0);
            this.Torches = new Torches[]
            {
                new Torches()
                {
                    color = "#71310a",
                    range = 16,
                    intensity = 12.5f
                }
            };
            PowerManager.ValidateBlockID(this.TypeName, new BasicGenerator());
        }
    }

    [NCAPIPowerType]
    public class GeneratorBlockLitXMinus : BaseType
    {
        public GeneratorBlockLitXMinus() : base("GeneratorLitX-", false)
        {
            this.ParentType = "GeneratorLit";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 180, 0);
            this.Torches = new Torches[]
            {
                new Torches()
                {
                    color = "#71310a",
                    range = 16,
                    intensity = 12.5f
                }
            };
            PowerManager.ValidateBlockID(this.TypeName, new BasicGenerator());
        }
    }

    [NCAPIPowerType]
    public class GeneratorBlockLitZPlus : BaseType
    {
        public GeneratorBlockLitZPlus() : base("GeneratorLitZ+", false)
        {
            this.ParentType = "GeneratorLit";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 270, 0);
            this.Torches = new Torches[]
            {
                new Torches()
                {
                    color = "#71310a",
                    range = 16,
                    intensity = 12.5f
                }
            };
            PowerManager.ValidateBlockID(this.TypeName, new BasicGenerator());
        }
    }

    [NCAPIPowerType]
    public class GeneratorBlockLitZMinus : BaseType
    {
        public GeneratorBlockLitZMinus() : base("GeneratorLitZ-", false)
        {
            this.ParentType = "GeneratorLit";
            this.IsPlaceable = true;
            this.MeshRotationEuler = new Pipliz.Vector3Int(0, 90, 0);
            this.Torches = new Torches[]
            {
                new Torches()
                {
                    color = "#71310a",
                    range = 16,
                    intensity = 12.5f
                }
            };
            PowerManager.ValidateBlockID(this.TypeName, new BasicGenerator());
        }
    }

    public class BasicGenerator : Generator
    {
        public BasicGenerator() : base("Generator", 1000, 30)
        { }
    }
}
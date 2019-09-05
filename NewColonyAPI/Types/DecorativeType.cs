using PhentrixGames.NewColonyAPI.Meshes;

namespace PhentrixGames.NewColonyAPI.Types
{
    public class DecorativeType : BaseType
    {
        public DecorativeType(string name, string shape, string icon) : base(name + shape, false)
        {
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stonePlace";

            this.Icon = icon;
            this.IsRotatable = true;
            this.RotatableXMinus = name + shape + "x-";
            this.RotatableXPlus = name + shape + "x+";
            this.RotatableZMinus = name + shape + "z-";
            this.RotatableZPlus = name + shape + "z+";
        }

        public DecorativeType(string name, string shape, string icon, string modname) : base(name + shape, false)
        {
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stonePlace";

            this.Icon = icon;
            this.IsRotatable = true;
            if (MeshManager.GetMesh(modname, shape, out string mesh))
            {
                this.Mesh = mesh;
            }
        }
    }

    public class DecorativeTypeXMinus : BaseType
    {
        public DecorativeTypeXMinus(string name, string shape, string meshFolder, string meshtype = ".obj") : base(name + shape + "x-", false)
        {
            this.ParentType = name + shape;
            this.Mesh = Helpers.Utilities.MultiCombine(meshFolder, shape + "x-" + meshtype);
            this.IsPlaceable = true;
        }

        public DecorativeTypeXMinus(string name, string shape, string modname) : base(name + shape + "x-", false)
        {
            this.ParentType = name + shape;
            this.IsPlaceable = true;
            if (MeshManager.GetMesh(modname, shape + "x-", out string mesh))
            {
                this.Mesh = mesh;
            }
        }
    }

    public class DecorativeTypeXPlus : BaseType
    {
        public DecorativeTypeXPlus(string name, string shape, string meshFolder, string meshtype = ".obj") : base(name + shape + "x+", false)
        {
            this.ParentType = name + shape;
            this.Mesh = Helpers.Utilities.MultiCombine(meshFolder, shape + "x+" + meshtype);
            this.IsPlaceable = true;
        }

        public DecorativeTypeXPlus(string name, string shape, string modname) : base(name + shape + "x+", false)
        {
            this.ParentType = name + shape;
            this.IsPlaceable = true;
            if (MeshManager.GetMesh(modname, shape + "x+", out string mesh))
            {
                this.Mesh = mesh;
            }
        }
    }

    public class DecorativeTypeZMinus : BaseType
    {
        public DecorativeTypeZMinus(string name, string shape, string meshFolder, string meshtype = ".obj") : base(name + shape + "z-", false)
        {
            this.ParentType = name + shape;
            this.Mesh = Helpers.Utilities.MultiCombine(meshFolder, shape + "z-" + meshtype);
            this.IsPlaceable = true;
        }

        public DecorativeTypeZMinus(string name, string shape, string modname) : base(name + shape + "z-", false)
        {
            this.ParentType = name + shape;
            this.IsPlaceable = true;
            if (MeshManager.GetMesh(modname, shape + "z-", out string mesh))
            {
                this.Mesh = mesh;
            }
        }
    }

    public class DecorativeTypeZPlus : BaseType
    {
        public DecorativeTypeZPlus(string name, string shape, string meshFolder, string meshtype = ".obj") : base(name + shape + "z+", false)
        {
            this.ParentType = name + shape;
            this.Mesh = Helpers.Utilities.MultiCombine(meshFolder, shape + "z+" + meshtype);
            this.IsPlaceable = true;
        }

        public DecorativeTypeZPlus(string name, string shape, string modname) : base(name + shape + "z+", false)
        {
            this.ParentType = name + shape;
            this.IsPlaceable = true;
            if (MeshManager.GetMesh(modname, shape + "z+", out string mesh))
            {
                this.Mesh = mesh;
            }
        }
    }
}
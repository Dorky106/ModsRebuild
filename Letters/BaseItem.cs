using PhentrixGames.NewColonyAPI.Meshes;
using PhentrixGames.NewColonyAPI.Types;
using System.Collections.Generic;

namespace PhentrixGames.Letters
{
    public class BaseItem : BaseType
    {
        public enum Rotation
        {
            Base,
            XPlus,
            XMinus,
            ZPlus,
            ZMinus
        }

        public BaseItem(string name, string meshname, string hexcode, Rotation rotation, bool lit) : base()
        {
            if (rotation == Rotation.Base)
            {
                this.IsPlaceable = true;
                this.IsRotatable = true;
                this.Icon = NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModIconDirectory, name + ".png");
                this.Categories = new List<string>()
                {
                    "decorative"
                };
                if (MeshManager.GetMesh(Entry.ModName, meshname, out string mesh))
                {
                    this.Mesh = mesh;
                }

                if (lit)
                {
                    this.TypeName = name + "lit";
                    this.SideAll = "ColouredLettersLit";
                    this.RotatableXMinus = name + "litxminus";
                    this.RotatableXPlus = name + "litxplus";
                    this.RotatableZMinus = name + "litzminus";
                    this.RotatableZPlus = name + "litzplus";
                }
                else
                {
                    this.TypeName = name;
                    this.SideAll = "ColouredLetters";
                    this.RotatableXMinus = name + "xminus";
                    this.RotatableXPlus = name + "xplus";
                    this.RotatableZMinus = name + "zminus";
                    this.RotatableZPlus = name + "zplus";
                }
            }

            switch (rotation)
            {
                case Rotation.XMinus:
                    if (lit)
                    {
                        this.ParentType = name + "lit";
                        this.TypeName = name + "litxminus";
                        this.Torches = new Torches[]
                        {
                            new Torches()
                            {
                                color = "#"+hexcode,
                                range = 1,
                                intensity = 10f,
                                volume = 1f
                            }
                        };
                    }
                    else
                    {
                        this.ParentType = name;
                        this.TypeName = name + "xminus";
                    }
                    this.OnRemove = new ItemTypes.ItemTypeRawDrops[] { new ItemTypes.ItemTypeRawDrops(this.ParentType, 1, 1) };
                    this.Colors = new string[] { "#ff0000->#" + hexcode };
                    this.MeshRotationEuler = new Pipliz.Vector3Int(0, 90, 0);
                    break;

                case Rotation.XPlus:
                    if (lit)
                    {
                        this.ParentType = name + "lit";
                        this.TypeName = name + "litxplus";
                        this.Torches = new Torches[]
                        {
                            new Torches()
                            {
                                color = "#"+hexcode,
                                range = 1,
                                intensity = 10f,
                                volume = 1f
                            }
                        };
                    }
                    else
                    {
                        this.ParentType = name;
                        this.TypeName = name + "xplus";
                    }
                    this.OnRemove = new ItemTypes.ItemTypeRawDrops[] { new ItemTypes.ItemTypeRawDrops(this.ParentType, 1, 1) };
                    this.Colors = new string[] { "#ff0000->#" + hexcode };
                    this.MeshRotationEuler = new Pipliz.Vector3Int(0, 270, 0);
                    break;

                case Rotation.ZMinus:
                    if (lit)
                    {
                        this.ParentType = name + "lit";
                        this.TypeName = name + "litzminus";
                        this.Torches = new Torches[]
                        {
                            new Torches()
                            {
                                color = "#"+hexcode,
                                range = 1,
                                intensity = 10f,
                                volume = 1f
                            }
                        };
                    }
                    else
                    {
                        this.ParentType = name;
                        this.TypeName = name + "zminus";
                    }
                    this.OnRemove = new ItemTypes.ItemTypeRawDrops[] { new ItemTypes.ItemTypeRawDrops(this.ParentType, 1, 1) };
                    this.Colors = new string[] { "#ff0000->#" + hexcode };
                    //this.MeshRotationEuler = new Pipliz.Vector3Int(0, 0, 0);
                    break;

                case Rotation.ZPlus:

                    if (lit)
                    {
                        this.ParentType = name + "lit";
                        this.TypeName = name + "litzplus";
                        this.Torches = new Torches[]
                        {
                            new Torches()
                            {
                                color = "#"+hexcode,
                                range = 1,
                                intensity = 10f,
                                volume = 1f
                            }
                        };
                    }
                    else
                    {
                        this.ParentType = name;
                        this.TypeName = name + "zplus";
                    }
                    this.OnRemove = new ItemTypes.ItemTypeRawDrops[] { new ItemTypes.ItemTypeRawDrops(this.ParentType, 1, 1) };
                    this.Colors = new string[] { "#ff0000->#" + hexcode };
                    this.MeshRotationEuler = new Pipliz.Vector3Int(0, 180, 0);
                    break;
            }
        }
    }
}
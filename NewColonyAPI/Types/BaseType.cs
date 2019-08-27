using PhentrixGames.NewColonyAPI.Recipe;
using Pipliz;
using Pipliz.JSON;
using System.Collections.Generic;
using System.IO;

namespace PhentrixGames.NewColonyAPI.Types
{
    public class BaseType
    {
        // The JSONNode that holds the data
        public JSONNode node = new JSONNode(NodeType.Object);

        public void Writenode()
        {
            JSON.Serialize(Path.Combine(NewColonyAPIEntry.ModGamedataDirectory, "crap.json").Replace("\\", "/"), this.node);
        }

        private string _TypeName;

        public string TypeName
        {
            get
            {
                return this._TypeName;
            }
            set
            {
                this._TypeName = value;
            }
        }

        private bool _OverrideReplace;

        public bool OverrideReplace
        {
            get
            {
                return this._OverrideReplace;
            }
            set
            {
                this._OverrideReplace = value;
            }
        }

        private bool _IsDestructible;

        public bool IsDestructible
        {
            get
            {
                return this._IsDestructible;
            }
            set
            {
                this._IsDestructible = value;
                this.node.SetAs("isDestructible", value);
            }
        }

        private bool _IsRotatable;

        public bool IsRotatable
        {
            get
            {
                return this._IsRotatable;
            }
            set
            {
                this._IsRotatable = value;
                this.node.SetAs("isRotatable", value);
            }
        }

        private bool _IsSolid;

        public bool IsSolid
        {
            get
            {
                return this._IsSolid;
            }
            set
            {
                this._IsSolid = value;
                this.node.SetAs("isSolid", value);
            }
        }

        private bool _IsFertile;

        public bool IsFertile
        {
            get
            {
                return this._IsFertile;
            }
            set
            {
                this._IsFertile = value;
                this.node.SetAs("isFertile", value);
            }
        }

        private bool _IsPlaceable;

        public bool IsPlaceable
        {
            get
            {
                return this._IsPlaceable;
            }
            set
            {
                this._IsPlaceable = value;
                this.node.SetAs("isPlaceable", value);
            }
        }

        private bool _NeedsBase;

        public bool NeedsBase
        {
            get
            {
                return this._NeedsBase;
            }
            set
            {
                this._NeedsBase = value;
                this.node.SetAs("needsBase", value);
            }
        }

        private ushort _MaxStackSize;

        public ushort MaxStackSize
        {
            get
            {
                return this._MaxStackSize;
            }
            set
            {
                this._MaxStackSize = value;
                this.node.SetAs("maxStackSize", value);
            }
        }

        private float _FoodValue;

        public float FoodValue
        {
            get
            {
                return this._FoodValue;
            }
            set
            {
                this._FoodValue = value;
                this.node.SetAs("foodValue", value);
            }
        }

        private float _DailyFoodFractionOptimal;

        public float DailyFoodFractionOptimal
        {
            get
            {
                return _DailyFoodFractionOptimal;
            }
            set
            {
                _DailyFoodFractionOptimal = value;
                this.node.SetAs("dailyFoodFactionOptimal", value);
            }
        }

        private float _LuxuryHours;

        public float LuxuryHours
        {
            get
            {
                return _LuxuryHours;
            }
            set
            {
                _LuxuryHours = value;
                this.node.SetAs("luxuryhours", value);
            }
        }

        private float _Happiness;

        public float Happiness
        {
            get
            {
                return _Happiness;
            }
            set
            {
                _Happiness = value;
                this.node.SetAs("happiness", value);
            }
        }

        private string _Mesh;

        public string Mesh
        {
            get
            {
                return this._Mesh;
            }
            set
            {
                this._Mesh = value;
                this.node.SetAs("mesh", value);
            }
        }

        private string _Icon;

        public string Icon
        {
            get
            {
                return this._Icon;
            }
            set
            {
                if (Helpers.Utilities.ValidateIcon(value))
                {
                    this._Icon = value;
                    this.node.SetAs("icon", value);
                }
                else
                {
                    this._Icon = Path.Combine(NewColonyAPIEntry.ModIconDirectory, "error.png").Replace("\\", "/");
                    this.node.SetAs("icon", this._Icon);
                }
            }
        }

        private string _OnRemoveAudio;

        public string OnRemoveAudio
        {
            get
            {
                return this._OnRemoveAudio;
            }
            set
            {
                this._OnRemoveAudio = value;
                this.node.SetAs("onRemoveAudio", value);
            }
        }

        private string _OnPlaceAudio;

        public string OnPlaceAudio
        {
            get
            {
                return this._OnPlaceAudio;
            }
            set
            {
                this._OnPlaceAudio = value;
                this.node.SetAs("onPlaceAudio", value);
            }
        }

        private long _DestructionTime;

        public long DestructionTime
        {
            get
            {
                return this._DestructionTime;
            }
            set
            {
                this._DestructionTime = value;
                this.node.SetAs("destructionTime", value);
            }
        }

        private string _ParentType;

        public string ParentType
        {
            get
            {
                return this._ParentType;
            }
            set
            {
                this._ParentType = value;
                this.node.SetAs("parentType", value);
            }
        }

        private string _RotatableXPlus;

        public string RotatableXPlus
        {
            get
            {
                return this._RotatableXPlus;
            }
            set
            {
                this._RotatableXPlus = value;
                this.node.SetAs("rotatablex+", value);
            }
        }

        private string _RotatableXMinus;

        public string RotatableXMinus
        {
            get
            {
                return this._RotatableXMinus;
            }
            set
            {
                this._RotatableXMinus = value;
                this.node.SetAs("rotatablex-", value);
            }
        }

        private string _RotatableZPlus;

        public string RotatableZPlus
        {
            get
            {
                return this._RotatableZPlus;
            }
            set
            {
                this._RotatableZPlus = value;
                this.node.SetAs("rotatablez+", value);
            }
        }

        private string _RotatableZMinus;

        public string RotatableZMinus
        {
            get
            {
                return this._RotatableZMinus;
            }
            set
            {
                this._RotatableZMinus = value;
                this.node.SetAs("rotatablez-", value);
            }
        }

        private string _SideAll = "apierror";

        public string SideAll
        {
            get
            {
                return this._SideAll;
            }
            set
            {
                this._SideAll = value;
                this.node.SetAs("sideall", value);
            }
        }

        private string _SideXPlus;

        public string SideXPlus
        {
            get
            {
                return this._SideXPlus;
            }
            set
            {
                this._SideXPlus = value;
                this.node.SetAs("sidex+", value);
            }
        }

        private string _SideXMinus;

        public string SideXMinus
        {
            get
            {
                return this._SideXMinus;
            }
            set
            {
                this._SideXMinus = value;
                this.node.SetAs("sidex-", value);
            }
        }

        private string _SideYPlus;

        public string SideYPlus
        {
            get
            {
                return this._SideYPlus;
            }
            set
            {
                this._SideYPlus = value;
                this.node.SetAs("sidey+", value);
            }
        }

        private string _SideYMinus;

        public string SideYMinus
        {
            get
            {
                return this._SideYMinus;
            }
            set
            {
                this._SideYMinus = value;
                this.node.SetAs("sidey-", value);
            }
        }

        private string _SideZPlus;

        public string SideZPlus
        {
            get
            {
                return this._SideZPlus;
            }
            set
            {
                this._SideZPlus = value;
                this.node.SetAs("sidez+", value);
            }
        }

        private string _SideZMinus;

        public string SideZMinus
        {
            get
            {
                return this._SideZMinus;
            }
            set
            {
                this._SideZMinus = value;
                this.node.SetAs("sidez-", value);
            }
        }

        private string _Color;

        public string Color
        {
            get
            {
                return _Color;
            }
            set
            {
                _Color = value;
                this.node.SetAs("color", value);
            }
        }

        private int _OnRemoveType;

        public int OnRemoveType
        {
            get
            {
                return _OnRemoveType;
            }
            set
            {
                this._OnRemoveType = value;
                this.node.SetAs("onRemoveType", value);
            }
        }

        private int _OnRemoveAmount;

        public int OnRemoveAmount
        {
            get
            {
                return this._OnRemoveAmount;
            }
            set
            {
                this._OnRemoveAmount = value;
                this.node.SetAs("onRemoveAmount", value);
            }
        }

        private float _OnRemoveChance;

        public float OnRemoveChance
        {
            get
            {
                return _OnRemoveChance;
            }
            set
            {
                this._OnRemoveChance = value;
                this.node.SetAs("onRemoveChance", value);
            }
        }

        private ItemTypes.ItemTypeRawDrops[] _OnRemove;

        public ItemTypes.ItemTypeRawDrops[] OnRemove
        {
            get
            {
                return this._OnRemove;
            }
            set
            {
                this._OnRemove = value;

                // make the on remove node node
                JSONNode orn = new JSONNode(NodeType.Array);

                // iterate over the list of onRemove structs, and add them to nodes, which are added to the node list
                for (int i = 0; i < value.Length; i++)
                {
                    orn.AddToArray(new JSONNode(NodeType.Object).SetAs("type", value[i].type).SetAs("amount", value[i].amount).SetAs("chance", value[i].chance));
                }

                this.node.SetAs("onRemove", orn);
            }
        }

        private List<BoundsPip> _Colliders = null;

        public List<BoundsPip> Colliders
        {
            get
            {
                return _Colliders;
            }
            set
            {
                _Colliders = value;
                JSONNode col = new JSONNode(NodeType.Object);
                JSONNode orn = new JSONNode(NodeType.Array);

                for (int i = 0; i < value.Count; i++)
                {
                    JSONNode tmp1 = new JSONNode(NodeType.Array);
                    tmp1.AddToArray(new JSONNode(value[i].Max.x));
                    tmp1.AddToArray(new JSONNode(value[i].Max.y));
                    tmp1.AddToArray(new JSONNode(value[i].Max.z));
                    JSONNode tmp2 = new JSONNode(NodeType.Array);
                    tmp2.AddToArray(new JSONNode(value[i].Min.x));
                    tmp2.AddToArray(new JSONNode(value[i].Min.y));
                    tmp2.AddToArray(new JSONNode(value[i].Min.z));
                    orn.AddToArray(new JSONNode(NodeType.Object).SetAs("max", tmp1).SetAs("min", tmp2));
                }
                /*
				for (int i = 0; i < value.bounds.Count; i++)
				{
					JSONNode tmp1 = new JSONNode(NodeType.Array);
					tmp1.AddToArray(new JSONNode(value.bounds[i].Max.x));
					tmp1.AddToArray(new JSONNode(value.bounds[i].Max.y));
					tmp1.AddToArray(new JSONNode(value.bounds[i].Max.z));
					JSONNode tmp2 = new JSONNode(NodeType.Array);
					tmp2.AddToArray(new JSONNode(value.bounds[i].Min.x));
					tmp2.AddToArray(new JSONNode(value.bounds[i].Min.y));
					tmp2.AddToArray(new JSONNode(value.bounds[i].Min.z));
					orn.AddToArray(new JSONNode(NodeType.Object).SetAs("max", tmp1).SetAs("min", tmp2));
				}
				col.SetAs("boxes", orn);
				if(value.collidePlayer == false)
				{
					col.SetAs("collidePlayer", false);
				}
				*/
                col.SetAs("boxes", orn);
                this.node.SetAs("colliders", col);
            }
        }

        private bool _CollidePlayer = true;

        public bool CollidePlayer
        {
            get
            {
                return _CollidePlayer;
            }
            set
            {
                if (_Colliders != null)
                {
                    this.node["colliders"].SetAs("collidePlayer", value);
                }
                else
                {
                    JSONNode col = new JSONNode(NodeType.Object);
                    JSONNode orn = new JSONNode(NodeType.Array);

                    JSONNode tmp1 = new JSONNode(NodeType.Array);
                    tmp1.AddToArray(new JSONNode(0.5f));
                    tmp1.AddToArray(new JSONNode(0.5f));
                    tmp1.AddToArray(new JSONNode(0.5f));

                    JSONNode tmp2 = new JSONNode(NodeType.Array);
                    tmp2.AddToArray(new JSONNode(-0.5f));
                    tmp2.AddToArray(new JSONNode(-0.5f));
                    tmp2.AddToArray(new JSONNode(-0.5f));

                    col.SetAs("boxes", orn);
                    col.SetAs("collidePlayer", value);
                    this.node.SetAs("colliders", col);
                }
            }
        }

        private bool _BlocksPathing = false;

        public bool BlocksPathing
        {
            get
            {
                return _BlocksPathing;
            }
            set
            {
                _BlocksPathing = value;
                this.node.SetAs("blocksPathing", value);
            }
        }

        private List<string> _Categories = new List<string>();

        public List<string> Categories
        {
            get
            {
                return _Categories;
            }
            set
            {
                _Categories = value;
                JSONNode orn = new JSONNode(NodeType.Array);
                for (int i = 0; i < value.Count; i++)
                {
                    orn.AddToArray(new JSONNode(value[i]));
                }
                this.node.SetAs("categories", orn);
            }
        }

        public JSONNode _CustomData
        {
            get;
            private set;
        } = new JSONNode(NodeType.Object);

        private string[] _Colors;

        public string[] Colors
        {
            get
            {
                return _Colors;
            }
            set
            {
                this._Colors = value;
                JSONNode cnode = new JSONNode(NodeType.Array);
                foreach (string str in value)
                {
                    cnode.AddToArray(new JSONNode(str));
                }
                this._CustomData.SetAs("colors", cnode);
            }
        }

        private string[] _AttachBehaviour;

        public string[] AttachBehaviour
        {
            get
            {
                return _AttachBehaviour;
            }
            set
            {
                _AttachBehaviour = value;
                JSONNode bhnode = new JSONNode(NodeType.Array);
                foreach (var item in value)
                {
                    JSONNode child = new JSONNode(NodeType.Object);
                    bhnode.AddToArray(child);
                }
                this._CustomData.SetAs("attachBehaviour", bhnode);
            }
        }

        private bool _FarShadows;

        public bool FarShadows
        {
            get
            {
                return _FarShadows;
            }
            set
            {
                _FarShadows = value;
                this._CustomData.SetAs("farShadows", value);
            }
        }

        private bool _WarnRemoval;

        public bool WarnRemoval
        {
            get
            {
                return _WarnRemoval;
            }
            set
            {
                _WarnRemoval = value;
                this._CustomData.SetAs("warnRemoval", value);
            }
        }

        private bool _MinerIsMineable;

        public bool MinerIsMineable
        {
            get
            {
                return _MinerIsMineable;
            }
            set
            {
                _MinerIsMineable = value;
                this._CustomData.SetAs("minerIsMineable", value);
            }
        }

        private int _MinerMiningtime;

        public int MinerMiningtime
        {
            get
            {
                return _MinerMiningtime;
            }
            set
            {
                _MinerMiningtime = value;
                this._CustomData.SetAs("minerMiningtime", value);
            }
        }

        private Torches[] _Torches;

        public Torches[] Torches
        {
            get
            {
                return _Torches;
            }
            set
            {
                this._Torches = value;
                JSONNode torches = new JSONNode(NodeType.Object);
                if (value.Length != 0)
                {
                    int cnt = 1;
                    if (value.Length >= 2)
                        cnt = 2;
                    for (int i = 0; i < cnt; i++)
                    {
                        JSONNode letter = new JSONNode(NodeType.Object);
                        if (value[i].range < 1)
                            value[i].range = 1;
                        if (value[i].range > 16)
                            value[i].range = 16;
                        if (value[i].intensity < 0)
                            value[i].intensity = 0;

                        letter.SetAs("color", value[i].color);
                        letter.SetAs("range", value[i].range);
                        if (value[i].intensity != 0f)
                            letter.SetAs("intensity", value[i].intensity);
                        if (value[i].offsetx != 0f)
                            letter.SetAs("offsetx", value[i].offsetx);
                        if (value[i].offsety != 0f)
                            letter.SetAs("offsety", value[i].offsety);
                        if (value[i].volume != 0f)
                            letter.SetAs("volume", value[i].volume);

                        if (i == 0)
                            torches.SetAs("a", letter);
                        if (i == 1)
                            torches.SetAs("b", letter);
                    }
                    this._CustomData.SetAs("torches", torches);
                }
            }
        }

        private bool _UseNormalMap = false;

        public bool UseNormalMap
        {
            get
            {
                return _UseNormalMap;
            }
            set
            {
                _UseNormalMap = value;
                _CustomData.SetAs("useNormalMap", value);
            }
        }

        private bool _UseHeightMap = false;

        public bool UseHeightMap
        {
            get
            {
                return _UseHeightMap;
            }
            set
            {
                _UseHeightMap = value;
                _CustomData.SetAs("useHeightMap", value);
            }
        }

        private string _RenderOnlyIfSelected;

        public string RenderOnlyIfSelected
        {
            get
            {
                return _RenderOnlyIfSelected;
            }
            set
            {
                this._RenderOnlyIfSelected = value;
                this._CustomData.SetAs("renderOnlyIfSelected", value);
            }
        }

        private Vector3Int _MeshRotation;

        public Vector3Int MeshRotationEuler
        {
            get
            {
                return _MeshRotation;
            }
            set
            {
                _MeshRotation = value;
                JSONNode rotation = new JSONNode();
                rotation.SetAs("x", value.x);
                rotation.SetAs("y", value.y);
                rotation.SetAs("z", value.z);
                this.node.SetAs("meshRotationEuler", rotation);
            }
        }

        // Constructor
        public BaseType(bool recipe = false)
        {
            // Register the callback to add recipes
            //if (recipe)
            //    this.AddRecipeCallback();
        }

        public BaseType(string name, bool recipe = false)
        {
            this.TypeName = name;
            // save to JSON if this is a new item that's been added

            // set default sideall
            /*
            if (Managers.TextureManager.GetTextures().ContainsKey(name))
            {
                this._SideXMinus = "SELF";
                this.node.SetAs("sideall", "SELF");
            }
            */
            // set default isplacable
            this._IsPlaceable = false;
            this.node.SetAs("isPlaceable", false);

            // Register the callback to add recipes
            //if (recipe)
            //    this.AddRecipeCallback();
        }

        public BaseType(string name, bool recipe = false, ushort blocksides = 0)
        {
            this.TypeName = name;
            // save to JSON if this is a new item that's been added

            if (blocksides == 1)
            {
                this.SideXMinus = "XM";
                this.SideXPlus = "XP";
                this.SideZMinus = "ZM";
                this.SideZPlus = "ZP";
            }

            // set default isplacable
            this._IsPlaceable = false;
            this.node.SetAs("isPlaceable", false);

            // Register the callback to add recipes
            //if (recipe)
            //    this.AddRecipeCallback();
        }

        public JSONNode Register()
        {
            if (_CustomData.ChildCount != 0)
            {
                this.node.SetAs("customData", _CustomData);
            }
            return this.node;
        }

        #region Recipe Stuff

        // base Add Recipes function
        public virtual List<BaseRecipe> AddRecipes()
        {
            Helpers.Logging.WriteLog(NewColonyAPIEntry.ModName, "Trying to add Recipe for: " + this.TypeName, Helpers.Logging.LogType.Issue);
            throw new System.NotImplementedException();
        }

        // create a callback to the RecipeManager to have it attempt to generate recipes
        internal void AddRecipeCallback()
        {
            Recipe.RecipeManager.TypesThatHaveRecipes.Add(this);
        }

        #endregion Recipe Stuff

        public bool UpdateAdjacent
        {
            get;
            set;
        } = false;
    }
}
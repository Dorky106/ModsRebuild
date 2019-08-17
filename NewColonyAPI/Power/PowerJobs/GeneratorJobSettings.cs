using Jobs;
using NPC;
using Pipliz;

namespace PhentrixGames.NewColonyAPI.Power.PowerJobs
{
    public class GeneratorJobSettings : IBlockJobSettings
    {
        public ItemTypes.ItemType[] BlockTypes
        {
            get;
            set;
        }

        public NPCType NPCType
        {
            get;
            set;
        }

        public InventoryItem RecruitmentItem
        {
            get;
            set;
        }

        public InventoryItem EnergyItem
        {
            get;
            private set;
        }

        public string NPCTypeKey
        {
            get;
            set;
        }

        public string OnCraftedAudio
        {
            get;
            set;
        }

        public int MaxCraftsPerHaul
        {
            get;
            set;
        }

        public float CraftingCooldown
        {
            get;

            set;
        }

        public float NPCShopGameHourMinimum => TimeCycle.Settings.SleepTimeEnd;
        public float NPCShopGameHourMaximum => TimeCycle.Settings.SleepTimeStart;
        public bool ToSleep => TimeCycle.ShouldSleep;

        public GeneratorJobSettings()
        {
        }

        public GeneratorJobSettings(string blockType, string npcTypeKey, InventoryItem energyItem, float craftingCooldown = 5f, int maxCraftsPerHaul = 5, string onCraftedAudio = null)
        {
            if (blockType != null)
            {
                ItemTypes.ItemType baseType = ItemTypes.GetType(blockType);
                bool baseHasRotated = baseType.RotatedXPlus != null;
                BlockTypes = new ItemTypes.ItemType[5]
                {
                    baseType,
                    baseHasRotated ? ItemTypes.GetType(baseType.RotatedXPlus) : ItemTypes.GetType(blockType + "x+"),
                    baseHasRotated ? ItemTypes.GetType(baseType.RotatedXMinus) : ItemTypes.GetType(blockType + "x-"),
                    baseHasRotated ? ItemTypes.GetType(baseType.RotatedZPlus) : ItemTypes.GetType(blockType + "z+"),
                    baseHasRotated ? ItemTypes.GetType(baseType.RotatedZMinus) : ItemTypes.GetType(blockType + "z-")
                };
            }
            NPCTypeKey = npcTypeKey;
            NPCType = NPCType.GetByKeyNameOrDefault(npcTypeKey);
            CraftingCooldown = craftingCooldown;
            MaxCraftsPerHaul = maxCraftsPerHaul;
            OnCraftedAudio = onCraftedAudio;
            EnergyItem = energyItem;
        }

        public virtual Vector3Int GetJobLocation(BlockJobInstance instance)
        {
            return instance.Position;
        }

        public void OnGoalChanged(BlockJobInstance instanceBlock, NPCBase.NPCGoal goalOld, NPCBase.NPCGoal goalNew)
        {
            GeneratorJobInstance instance = (GeneratorJobInstance)instanceBlock;
            if (goalOld == NPCBase.NPCGoal.Job && instance.IsCrafting)
            {
                instance.IsCrafting = false;
                OnStopCrafting(instance);
            }
        }

        public virtual void OnNPCAtJob(BlockJobInstance blockJobInstance, ref NPCBase.NPCState state)
        {
            GeneratorJobInstance instance = (GeneratorJobInstance)blockJobInstance;
            NPCLookAtJobBlock(blockJobInstance);
            state.JobIsDone = true;
            //Make sure NPC actually has items
            if (state.Inventory.IsEmpty == false)
            {
                //Setup power info
                int power, maxpower;
                PowerManager.GetPower(blockJobInstance.Position, out power);
                PowerManager.GetMaxPower(blockJobInstance.Position, out maxpower);

                //Make sure generator needs power so resources are not wasted
                if (power != maxpower)
                {
                    //Remove EnergyItem from inventory
                    state.Inventory.Remove(EnergyItem);
                    state.SetIndicator(new Shared.IndicatorState(CraftingCooldown, ItemTypes.IndexLookup.GetIndex("electricity"), false, false));

                    //Generate power!
                    PowerManager.GeneratePower(blockJobInstance.Position);
                    if (instance.IsCrafting == false)
                    {
                        instance.IsCrafting = true;
                        OnStartCrafting(instance);
                    }
                }
                else
                {
                    if (instance.IsCrafting == true)
                    {
                        OnStopCrafting(instance);
                    }
                    state.SetIndicator(new Shared.IndicatorState(0.3f, ItemTypes.IndexLookup.GetIndex("electricity"), false, true));
                }
            }
            else
            {
                //Go get the needed items
                blockJobInstance.ShouldTakeItems = true;
                state.SetCooldown(0.3);
                if (instance.IsCrafting == true)
                {
                    OnStopCrafting(instance);
                }
            }
        }

        public virtual void OnNPCAtStockpile(BlockJobInstance blockJobInstance, ref NPCBase.NPCState state)
        {
            GeneratorJobInstance instance = (GeneratorJobInstance)blockJobInstance;
            if (state.Inventory.IsEmpty == false)
            {
                state.Inventory.Dump(blockJobInstance.Owner.Stockpile);
                state.SetCooldown(0.3);
            }
            state.JobIsDone = true;
            if (instance.ShouldTakeItems == false)
            {
                return;
            }
            instance.ShouldTakeItems = false;

            if (state.Inventory.IsEmpty)
            {
                //Repeat till inventory is full!
                //Check if EnergyItem exists in the stockpile
                if (blockJobInstance.Owner.Stockpile.TryRemove(EnergyItem.Type, EnergyItem.Amount * 5))
                {
                    //Take item and increase wait counter
                    state.Inventory.Add(EnergyItem.Type, EnergyItem.Amount * 5);
                }
            }
            //Make NPC wait 1 second
            state.SetCooldown(1);
        }

        private void NPCLookAtJobBlock(BlockJobInstance blockJobInstance)
        {
            blockJobInstance.NPC.LookAt(blockJobInstance.Position.Vector);
        }

        public virtual void OnStartCrafting(BlockJobInstance instance)
        {
        }

        public virtual void OnStopCrafting(BlockJobInstance instance)
        {
        }
    }
}
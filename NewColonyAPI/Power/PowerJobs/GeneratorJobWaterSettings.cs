using BlockTypes;
using Jobs;
using Pipliz;
using UnityEngine.Assertions;

namespace PhentrixGames.NewColonyAPI.Power.PowerJobs
{
    public class GeneratorJobWaterSettings : GeneratorJobSettings
    {
        public GeneratorJobWaterSettings()
        {
        }

        public GeneratorJobWaterSettings(
            string blockType,
            string npcTypeKey,
            InventoryItem energyItem,
            float craftingCooldown = 5,
            int maxCraftsPerHaul = 5,
            string onCraftedAudio = null
            ) : base(
                blockType,
                npcTypeKey,
                energyItem,
                craftingCooldown,
                maxCraftsPerHaul,
                onCraftedAudio
                )
        { }

        private bool CheckWater(GeneratorJobWaterInstance instance)
        {
            if (instance.WaterPoisiton != Pipliz.Vector3Int.invalidPos)
            {
                if (World.TryGetTypeAt(instance.WaterPoisiton, out ushort type) == false)
                {
                    return false;
                }
                if (type == BuiltinBlocks.Indices.water)
                {
                    return true;
                }
                instance.WaterPoisiton = Pipliz.Vector3Int.invalidPos;
            }
            Assert.IsTrue(instance.WaterPoisiton == Pipliz.Vector3Int.invalidPos, "Water position was not invalid");
            Vector3Int checkDir = WaterDirCheck(instance);
            for (int y = -1; y <= 0; y++)
            {
                if (World.TryGetTypeAt(instance.Position.Add(checkDir.x, y, checkDir.z), out ushort type2))
                {
                    if (type2 == BuiltinBlocks.Indices.water)
                    {
                        instance.WaterPoisiton = instance.Position.Add(0, y, 0);
                        return true;
                    }
                    continue;
                }
                return false;
            }

            return false;
        }

        private Vector3Int WaterDirCheck(BlockJobInstance instance)
        {
            Vector3Int pos = Vector3Int.zero;

            if (BlockTypes.ContainsByReference(instance.BlockType, out int index))
            {
                switch (index)
                {
                    case 1:
                        pos.x--;
                        break;

                    case 2:
                        pos.x++;
                        break;

                    case 3:
                        pos.z--;
                        break;

                    case 4:
                        pos.z++;
                        pos.z++;
                        break;
                }
            }

            return pos;
        }

        public override Vector3Int GetJobLocation(BlockJobInstance instance)
        {
            Vector3Int pos = instance.Position;

            if (BlockTypes.ContainsByReference(instance.BlockType, out int index))
            {
                switch (index)
                {
                    case 1:
                        pos.x++;
                        break;

                    case 2:
                        pos.x--;
                        break;

                    case 3:
                        pos.z++;
                        break;

                    case 4:
                        pos.z--;
                        break;
                }
            }

            return pos;
        }

        new public virtual void OnNPCAtStockpile(BlockJobInstance blockJobInstance, ref NPC.NPCBase.NPCState state)
        {
            blockJobInstance.ShouldTakeItems = false;
            state.Inventory.Dump(blockJobInstance.Owner.Stockpile);
            state.SetCooldown(0.3);
            state.JobIsDone = true;
        }

        public override void OnNPCAtJob(BlockJobInstance blockJobInstance, ref NPC.NPCBase.NPCState state)
        {
            GeneratorJobWaterInstance instance = (GeneratorJobWaterInstance)blockJobInstance;
            //Colony owner = instance.Owner;
            state.JobIsDone = true;
            if (!CheckWater(instance))
            {
                state.SetCooldown(0.3);
                return;
            }

            if (instance.counter >= 10)
            {
                instance.counter = 0;
                instance.ShouldTakeItems = true;
            }
            else
            {
                //Setup power info
                PowerManager.GetPower(blockJobInstance.Position, out int power);
                PowerManager.GetMaxPower(blockJobInstance.Position, out int maxpower);
                if (power != maxpower)
                {
                    state.SetIndicator(new Shared.IndicatorState(CraftingCooldown, ItemTypes.IndexLookup.GetIndex("electricity"), false, false));
                    PowerManager.GeneratePower(blockJobInstance.Position);
                    if (instance.IsCrafting == false)
                    {
                        instance.IsCrafting = true;
                        OnStartCrafting(blockJobInstance);
                    }
                    instance.counter++;
                }
                else
                {
                    state.SetCooldown(0.5);
                    if (instance.IsCrafting == true)
                    {
                        instance.IsCrafting = false;
                        OnStopCrafting(blockJobInstance);
                    }
                }
            }
        }
    }
}
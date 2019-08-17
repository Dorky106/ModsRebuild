using Jobs;
using Pipliz;

namespace PhentrixGames.NewColonyAPI.Power.PowerJobs
{
    public class GeneratorJobLitSettings : GeneratorJobSettings
    {
        public GeneratorJobLitSettings(string blockType, string npcTypeKey, InventoryItem energyitem, float craftingCooldown = 5f, int maxCraftsPerHaul = 5, string onCraftedAudio = null) : base(null, npcTypeKey, energyitem, craftingCooldown, maxCraftsPerHaul, onCraftedAudio)
        {
            if (blockType != null)
            {
                ItemTypes.ItemType baseType = ItemTypes.GetType(blockType);
                bool baseHasRotated = baseType.RotatedXPlus != null;
                ItemTypes.ItemType litType = ItemTypes.GetType(blockType + "Lit");
                bool litHasRotated = litType.RotatedXPlus != null;

                BlockTypes = new ItemTypes.ItemType[]
                {
                    baseType,
                    baseHasRotated ? ItemTypes.GetType(baseType.RotatedXPlus) : ItemTypes.GetType(blockType + "x+"),
                    baseHasRotated ? ItemTypes.GetType(baseType.RotatedXMinus) : ItemTypes.GetType(blockType + "x-"),
                    baseHasRotated ? ItemTypes.GetType(baseType.RotatedZPlus) : ItemTypes.GetType(blockType + "z+"),
                    baseHasRotated ? ItemTypes.GetType(baseType.RotatedZMinus) : ItemTypes.GetType(blockType + "z-"),

                    litType,
                    litHasRotated ? ItemTypes.GetType(litType.RotatedXPlus) : ItemTypes.GetType(litType.Name + "x+"),
                    litHasRotated ? ItemTypes.GetType(litType.RotatedXMinus) : ItemTypes.GetType(litType.Name + "x-"),
                    litHasRotated ? ItemTypes.GetType(litType.RotatedZPlus) : ItemTypes.GetType(litType.Name + "z+"),
                    litHasRotated ? ItemTypes.GetType(litType.RotatedZMinus) : ItemTypes.GetType(litType.Name + "z-"),
                };
            }
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

        public override void OnStartCrafting(BlockJobInstance instance)
        {
            if (!BlockTypes.ContainsByReference(instance.BlockType, out int index))
                return;

            int num = index;
            if ((uint)(num - 1) <= 3u)
            {
                ItemTypes.ItemType itemType = BlockTypes[index + 5];
                ESetBlockFlags flags = ESetBlockFlags.None;
                if (ServerManager.TryChangeBlock(instance.Position, instance.BlockType, itemType, instance.Owner, flags) == EServerChangeBlockResult.Success)
                {
                    instance.BlockType = itemType;
                }
            }
        }

        public override void OnStopCrafting(BlockJobInstance instance)
        {
            if (!BlockTypes.ContainsByReference(instance.BlockType, out int index))
                return;

            int num = index;
            if ((uint)(num - 6) <= 3u)
            {
                ItemTypes.ItemType newType = BlockTypes[index - 5];
                ESetBlockFlags flags = ESetBlockFlags.None;
                if (ServerManager.TryChangeBlock(instance.Position, instance.BlockType, newType, instance.Owner, flags) == EServerChangeBlockResult.Success)
                {
                    instance.BlockType = newType;
                }
            }
        }
    }
}
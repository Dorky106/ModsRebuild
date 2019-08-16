using Jobs;

namespace PhentrixGames.NewColonyAPI.NPCXP
{
    public class ImprovedCraftingSettings : Jobs.CraftingJobSettings
    {
        public NPC.NPCBase npc;

        public ImprovedCraftingSettings(NPC.NPCBase npc, Jobs.CraftingJobSettings settings) : base(settings.BlockTypes[0].Name, settings.NPCTypeKey, settings.CraftingCooldown, settings.MaxCraftsPerHaul, settings.OnCraftedAudio)
        {
            this.npc = npc;
        }

        public override float CraftingCooldown
        {
            get
            {
                if (NPCManager.Enabled)
                {
                    JobData jobData;
                    if (JobManager.GetJobData(npc.NPCType, out jobData))
                    {
                        NPCData npcdata = NPCManager.GetNPCData(npc.ID, npc.Colony);
                        return jobData.cooldown * npcdata.XPData.GetCraftingMultiplier(npc.Job.NPCType.ToString());
                    }
                }
                return base.CraftingCooldown;
            }
            set => base.CraftingCooldown = value;
        }
    }

    public class ImprovedCraftingJobRotatedLitSettings : Jobs.CraftingJobRotatedLitSettings
    {
        public NPC.NPCBase npc;

        public ImprovedCraftingJobRotatedLitSettings(NPC.NPCBase npc, Jobs.CraftingJobRotatedLitSettings settings) : base(settings.BlockTypes[0].Name, settings.NPCTypeKey, settings.CraftingCooldown, settings.MaxCraftsPerHaul, settings.OnCraftedAudio)
        {
            this.npc = npc;
        }

        public override float CraftingCooldown
        {
            get
            {
                if (NPCManager.Enabled)
                {
                    JobData jobData;
                    if (JobManager.GetJobData(npc.NPCType, out jobData))
                    {
                        NPCData npcdata = NPCManager.GetNPCData(npc.ID, npc.Colony);
                        return jobData.cooldown * npcdata.XPData.GetCraftingMultiplier(npc.Job.NPCType.ToString());
                    }
                }
                return base.CraftingCooldown;
            }
            set => base.CraftingCooldown = value;
        }
    }

    public class ImprovedCraftingJobRotatedSettings : Jobs.CraftingJobRotatedSettings
    {
        public NPC.NPCBase npc;

        public ImprovedCraftingJobRotatedSettings(NPC.NPCBase npc, Jobs.CraftingJobRotatedSettings settings) : base(settings.BlockTypes[0].Name, settings.NPCTypeKey, settings.CraftingCooldown, settings.MaxCraftsPerHaul, settings.OnCraftedAudio)
        {
            this.npc = npc;
        }

        public override float CraftingCooldown
        {
            get
            {
                if (NPCManager.Enabled)
                {
                    JobData jobData;
                    if (JobManager.GetJobData(npc.NPCType, out jobData))
                    {
                        NPCData npcdata = NPCManager.GetNPCData(npc.ID, npc.Colony);
                        return jobData.cooldown * npcdata.XPData.GetCraftingMultiplier(npc.Job.NPCType.ToString());
                    }
                }
                return base.CraftingCooldown;
            }
            set => base.CraftingCooldown = value;
        }
    }

    public class ImprovedCraftingWaterSettings : Jobs.CraftingJobWaterSettings
    {
        public NPC.NPCBase npc;

        public ImprovedCraftingWaterSettings(NPC.NPCBase npc, Jobs.CraftingJobWaterSettings settings) : base(settings.BlockTypes[0].Name, settings.NPCTypeString, settings.Cooldown, settings.MaxGatheredBeforeCrate, settings.OnCraftedAudio)
        {
            this.npc = npc;
        }

        public override float Cooldown
        {
            get
            {
                if (NPCManager.Enabled)
                {
                    JobData jobData;
                    if (JobManager.GetJobData(npc.NPCType, out jobData))
                    {
                        NPCData npcdata = NPCManager.GetNPCData(npc.ID, npc.Colony);
                        return jobData.cooldown * npcdata.XPData.GetCraftingMultiplier(npc.Job.NPCType.ToString());
                    }
                }
                return base.Cooldown;
            }
            set => base.Cooldown = value;
        }
    }

    public class ImprovedGuardJobSettings : Jobs.GuardJobSettings
    {
        public NPC.NPCBase npc;

        public ImprovedGuardJobSettings(NPC.NPCBase npc, GuardJobSettingData settings) : base(settings)
        {
            this.npc = npc;
        }

        public override float CooldownShot
        {
            get
            {
                if (NPCManager.Enabled)
                {
                    JobData jobData;
                    if (JobManager.GetJobData(npc.NPCType, out jobData))
                    {
                        NPCData npcdata = NPCManager.GetNPCData(npc.ID, npc.Colony);
                        return jobData.cooldown * npcdata.XPData.GetCraftingMultiplier(npc.Job.NPCType.ToString());
                    }
                }
                return base.CooldownShot;
            }
            set => base.CooldownShot = value;
        }
    }
}
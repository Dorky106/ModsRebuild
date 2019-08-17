using BlockTypes;
using Jobs;
using NPC;
using Pipliz;
using Recipes;
using Shared;
using System.Collections.Generic;
using UnityEngine.Assertions;

namespace PhentrixGames.NewColonyAPI.Power.PowerJobs
{
    public class MachineJobSettings : IBlockJobSettings
    {
        protected static List<RecipeResult> craftingResults = new List<RecipeResult>();

        public virtual ItemTypes.ItemType[] BlockTypes
        {
            get;

            set;
        }

        public virtual NPC.NPCType NPCType
        {
            get;
            set;
        }

        public virtual string NPCTypeKey
        {
            get;
            set;
        }

        public virtual InventoryItem RecruitmentItem
        {
            get;
            set;
        }

        public virtual float CraftingCooldown
        {
            get;
            set;
        }

        public virtual int MaxCraftsPerHaul
        {
            get;
            set;
        }

        public virtual string OnCraftedAudio
        {
            get;
            set;
        }

        public virtual bool ToSleep => TimeCycle.ShouldSleep;
        public virtual float NPCShopGameHourMinimum => TimeCycle.Settings.SleepTimeEnd;
        public virtual float NPCShopGameHourMaximum => TimeCycle.Settings.SleepTimeStart;

        public MachineJobSettings(string blockType, string npcTypeKey, float craftingCooldown = 5f, int maxCraftsPerHaul = 5, string onCraftedAudio = null)
        {
            if (blockType != null)
            {
                BlockTypes = new ItemTypes.ItemType[1]
                {
                    ItemTypes.GetType(blockType)
                };
            }
            NPCTypeKey = npcTypeKey;
            NPCType = NPC.NPCType.GetByKeyNameOrDefault(npcTypeKey);
            CraftingCooldown = craftingCooldown;
            MaxCraftsPerHaul = maxCraftsPerHaul;
            OnCraftedAudio = onCraftedAudio;
        }

        public virtual void OnStartCrafting(BlockJobInstance jobInstance)
        {
        }

        public virtual void OnStopCrafting(BlockJobInstance jobInstance)
        {
        }

        public Vector3Int GetJobLocation(BlockJobInstance jobInstance)
        {
            return jobInstance.Position;
        }

        public void OnNPCAtJob(BlockJobInstance jobInstance, ref NPCBase.NPCState state)
        {
            MachineJobInstance instance = (MachineJobInstance)jobInstance;
            NPCLookAtJobBlock(jobInstance);
            state.JobIsDone = true;
            if (instance.SelectedRecipe != null)
            {
                if (instance.SelectedRecipeCount > 0 && instance.SelectedRecipe.IsPossible(instance.Owner, state.Inventory))
                {
                    if (PowerManager.Operate(instance.Position))
                    {
                        state.Inventory.Remove(instance.SelectedRecipe.Requirements);
                        craftingResults.Clear();
                        craftingResults.Add(instance.SelectedRecipe.Results);
                        ModLoader.Callbacks.OnNPCCraftedRecipe.Invoke(instance, instance.SelectedRecipe, craftingResults);
                        if (craftingResults.Count > 0)
                        {
                            state.Inventory.Add(craftingResults);
                            RecipeResult toShow = RecipeResult.GetWeightedRandom(craftingResults);
                            if (toShow.Amount > 0)
                            {
                                //Possible way for varied Crafting speeds?
                                //ItemTypes.GetType(toShow.AsItem.Type).CustomDataNode["craftspeed"].GetAs<float>();
                                state.SetIndicator(new IndicatorState(CraftingCooldown, toShow.Type));
                            }
                            else
                            {
                                state.SetCooldown(CraftingCooldown);
                            }
                            if (OnCraftedAudio != null)
                            {
                                AudioManager.SendAudio(instance.Position.Vector, OnCraftedAudio);
                            }
                        }
                        else
                        {
                            state.SetIndicator(new IndicatorState(CraftingCooldown, NPCIndicatorType.None));
                        }
                        if (!instance.IsCrafting)
                        {
                            instance.IsCrafting = true;
                            OnStartCrafting(instance);
                        }
                        state.JobIsDone = false;
                        instance.SelectedRecipeCount--;
                    }
                    else
                    {
                        state.SetIndicator(new IndicatorState(0.3f, ItemTypes.IndexLookup.GetIndex("electricity"), true, false));
                    }
                }
                else
                {
                    instance.SelectedRecipe = null;
                    instance.SelectedRecipeCount = 0;
                    if (!state.Inventory.IsEmpty)
                    {
                        instance.ShouldTakeItems = true;
                    }
                    state.SetCooldown(0.1);
                    if (instance.IsCrafting)
                    {
                        instance.IsCrafting = false;
                        OnStopCrafting(instance);
                    }
                }
                return;
            }
            if (instance.IsCrafting)
            {
                instance.IsCrafting = false;
                OnStopCrafting(instance);
            }
            Recipes.Recipe.RecipeMatch recipeMatch = Recipes.Recipe.MatchRecipe(GetPossibleRecipes(instance), instance.Owner);
            switch (recipeMatch.MatchType)
            {
                case Recipes.Recipe.RecipeMatchType.FoundMissingRequirements:
                case Recipes.Recipe.RecipeMatchType.AllDone:
                    {
                        if (!state.Inventory.IsEmpty)
                        {
                            instance.ShouldTakeItems = true;
                            state.SetCooldown(0.3);
                            break;
                        }
                        state.JobIsDone = false;
                        float cooldown = Pipliz.Random.NextFloat(8f, 16f);
                        if (recipeMatch.MatchType == Recipes.Recipe.RecipeMatchType.AllDone)
                        {
                            state.SetIndicator(new IndicatorState(cooldown, BuiltinBlocks.Indices.erroridle));
                        }
                        else
                        {
                            state.SetIndicator(new IndicatorState(cooldown, recipeMatch.FoundRecipe.FindMissingType(instance.Owner.Stockpile), striked: true, green: false));
                        }
                        break;
                    }
                case Recipes.Recipe.RecipeMatchType.FoundCraftable:
                    instance.SelectedRecipe = recipeMatch.FoundRecipe;
                    instance.ShouldTakeItems = true;
                    state.SetCooldown(0.3);
                    break;

                default:
                    Assert.IsTrue(condition: false, "Unexpected RecipeMatchType: " + recipeMatch.MatchType);
                    break;
            }
        }

        private void NPCLookAtJobBlock(BlockJobInstance jobInstance)
        {
            jobInstance.NPC.LookAt(jobInstance.Position.Vector);
        }

        public void OnNPCAtStockpile(BlockJobInstance jobInstance, ref NPCBase.NPCState state)
        {
            MachineJobInstance instance = (MachineJobInstance)jobInstance;
            if (!state.Inventory.IsEmpty)
            {
                state.Inventory.Dump(instance.Owner.Stockpile);
                state.SetCooldown(0.3);
            }
            state.JobIsDone = true;
            if (!instance.ShouldTakeItems)
            {
                return;
            }
            instance.ShouldTakeItems = false;
            Recipes.Recipe.RecipeMatch recipeMatch = Recipes.Recipe.MatchRecipe(GetPossibleRecipes(instance), instance.Owner);
            switch (recipeMatch.MatchType)
            {
                case Recipes.Recipe.RecipeMatchType.FoundMissingRequirements:
                case Recipes.Recipe.RecipeMatchType.AllDone:
                    state.SetCooldown(0.5);
                    instance.SelectedRecipeCount = 0;
                    break;

                case Recipes.Recipe.RecipeMatchType.FoundCraftable:
                    {
                        instance.SelectedRecipe = recipeMatch.FoundRecipe;
                        instance.SelectedRecipeCount = Pipliz.Math.Min(recipeMatch.FoundRecipeCount, MaxCraftsPerHaul);
                        List<InventoryItem> reqs = instance.SelectedRecipe.Requirements;
                        for (int i = 0; i < reqs.Count; i++)
                        {
                            state.Inventory.Add(reqs[i] * instance.SelectedRecipeCount);
                            instance.Owner.Stockpile.TryRemove(reqs[i] * instance.SelectedRecipeCount);
                        }
                        state.SetCooldown(0.5);
                        break;
                    }
                default:
                    Assert.IsTrue(condition: false, "Unexpected RecipeMatchType: " + recipeMatch.MatchType);
                    break;
            }
        }

        public void OnGoalChanged(BlockJobInstance jobInstance, NPCBase.NPCGoal goalOld, NPCBase.NPCGoal goalNew)
        {
            MachineJobInstance instance = (MachineJobInstance)jobInstance;
            if (goalOld == NPCBase.NPCGoal.Job && instance.IsCrafting)
            {
                instance.IsCrafting = false;
                OnStopCrafting(instance);
            }
        }

        private static ushort GetWeightedRandomItem(List<ItemTypes.ItemTypeDrops> items)
        {
            ushort typeToShow = items[0].item.Type;
            if (items.Count > 1)
            {
                int totalTypes2 = 0;
                for (int j = 0; j < items.Count; j++)
                {
                    totalTypes2 += items[j].item.Amount;
                }
                totalTypes2 = Pipliz.Random.Next(0, totalTypes2 + 1);
                for (int i = 0; i < items.Count; i++)
                {
                    totalTypes2 -= items[i].item.Amount;
                    if (totalTypes2 <= 0)
                    {
                        typeToShow = items[i].item.Type;
                        break;
                    }
                }
            }
            return typeToShow;
        }

        public virtual AvailableRecipesEnumerator GetPossibleRecipes(IJob job)
        {
            return job.Owner.RecipeData.GetAvailableRecipes(NPCTypeKey);
        }
    }
}
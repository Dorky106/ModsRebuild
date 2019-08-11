﻿using Pipliz.JSON;
using System.Collections.Generic;

namespace PhentrixGames.NewColonyAPI.Recipe
{
    public class BaseRecipe
    {
        public string Name
        {
            get;
            protected set;
        }
        public string Job
        {
            get;
            protected set;
        } = null;
        public int Limit
        {
            get;
            protected set;
        } = 200;
        public int Priority
        {
            get;
            protected set;
        } = 0;
        public List<InventoryItem> Requirements
        {
            get;
            protected set;
        }
        public List<InventoryItem> Result
        {
            get;
            protected set;
        }
        public bool PlayerRecipe
        {
            get;
            protected set;
        } = false;
        public BaseRecipe(string name, string job, bool playerrecipe = false)
        {
            Name = name;
            Job = job;
            PlayerRecipe = playerrecipe;
        }
        public BaseRecipe(string name, string job, bool playerrecipe = false, int limit = 200, int priority = 0)
        {
            Name = name;
            Job = job;
            PlayerRecipe = playerrecipe;
            Limit = limit;
            Priority = priority;
        }
        public void RegisterRecipe()
        {
            JSONNode node = new JSONNode(NodeType.Object);

            JSONNode noderequirements = new JSONNode(NodeType.Array);
            foreach (InventoryItem ii in Requirements)
            {
                JSONNode noderequirement = new JSONNode(NodeType.Object);
                noderequirement.SetAs("amount", ii.Amount);
                noderequirement.SetAs("type", ItemTypes.IndexLookup.GetName(ii.Type));
                noderequirements.AddToArray(noderequirement);
            }
            node.SetAs("requires", noderequirements);

            JSONNode noderesults = new JSONNode(NodeType.Array);
            foreach (InventoryItem ii in Result)
            {
                JSONNode noderesult = new JSONNode(NodeType.Object);
                noderesult.SetAs("amount", ii.Amount);
                noderesult.SetAs("type", ItemTypes.IndexLookup.GetName(ii.Type));
                noderesults.AddToArray(noderesult);
            }
            node.SetAs("results", noderesults);

            if(PlayerRecipe)
            {
                node.SetAs("name", Name + ".Player");
                List<JSONNode> playerData = new List<JSONNode>();
                playerData.Add(node);
                Recipes.RecipeStorage.PlayerRecipePatch playerRecipePatch = new Recipes.RecipeStorage.PlayerRecipePatch(Recipes.RecipeStorage.EPlayerRecipePatchType.AddOrReplace, 12000, playerData);
                Recipes.RecipeStorage.QueuePlayerRecipes(playerRecipePatch);
            }
            if(Job != null && Job != "")
            {
                node.SetAs("name", Name + ".NPC");
                node.SetAs("defaultLimit", Limit);
                node.SetAs("defaultPriority", Priority);
                List<JSONNode> npcData = new List<JSONNode>();
                npcData.Add(node);
                Recipes.RecipeStorage.NPCRecipePatch npcRecipePatch = new Recipes.RecipeStorage.NPCRecipePatch(Recipes.RecipeStorage.ENPCRecipePatchType.AddOrReplace, 12000, npcData, Job);
                Recipes.RecipeStorage.QueueNPCRecipes(npcRecipePatch);

            }

        }
    }
}

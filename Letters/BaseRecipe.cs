using System.Collections.Generic;

namespace PhentrixGames.Letters
{
    public class BaseRecipe : NewColonyAPI.Recipe.BaseRecipe
    {
        public BaseRecipe(string name) : base(name, "pipliz.dyer", false, 10, 0)
        {
            this.Requirements = new List<InventoryItem>()
            {
                new InventoryItem("planks")
            };
            this.Result = new List<InventoryItem>()
            {
                new InventoryItem(name)
            };
        }
    }
}
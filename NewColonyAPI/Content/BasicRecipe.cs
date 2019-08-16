namespace PhentrixGames.NewColonyAPI.Content
{
    [Recipe.RecipeManager.NCAPIRecipe]
    public class BasicRecipe : Recipe.BaseRecipe
    {
        public BasicRecipe() : base("BasicBlock", null, true)
        {
            this.Requirements = new System.Collections.Generic.List<InventoryItem>()
            {
                new InventoryItem("planks")
            };

            this.Result = new System.Collections.Generic.List<InventoryItem>()
            {
                new InventoryItem("BasicBlock")
            };
        }
    }
}
namespace PhentrixGames.NewColonyAPI.Content
{
    public class PowerReaderRecipe : Recipe.BaseRecipe
    {
        public PowerReaderRecipe() : base("PowerReaderRecipe")
        {
            this.Requirements = new System.Collections.Generic.List<InventoryItem>
            {
                new InventoryItem("planks", 10)
            };
            this.Result = new System.Collections.Generic.List<InventoryItem>
            {
                new InventoryItem("Power Reader")
            };
        }
    }

    public class PowerReader : Types.BaseType
    {
        public PowerReader() : base("Power Reader", false)
        {
            this.IsPlaceable = false;
            this.Icon = Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModIconDirectory, "powerreader.png");
        }
    }
}
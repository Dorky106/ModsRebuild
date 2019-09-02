using PhentrixGames.NewColonyAPI.Recipe;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.NewRecipes
{
    [NCAPIPowerRecipe]
    public class sawmilllogtaigaRecipe : BaseRecipe
    {
        public sawmilllogtaigaRecipe() : base("sawmill.logtaiga.planks", "phentrixgames.sawmill", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("logtaiga", 1));
            Result.Add(new InventoryItem("planks", 6));
        }
    }

    [NCAPIPowerRecipe]
    public class sawmillloglogtemperateRecipe : BaseRecipe
    {
        public sawmillloglogtemperateRecipe() : base("sawmill.logtemperate.planks", "phentrixgames.sawmill", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("logtemperate", 1));
            Result.Add(new InventoryItem("planks", 6));
        }
    }
}
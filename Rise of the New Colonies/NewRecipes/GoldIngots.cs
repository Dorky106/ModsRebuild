using PhentrixGames.NewColonyAPI.Recipe;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.NewRecipes
{
    [NCAPIPowerRecipe]
    public class GoldIngots : BaseRecipe
    {
        public GoldIngots() : base("electricforge.goldingot", "phentrixgames.electricforge", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("goldore", 10));
            Requirements.Add(new InventoryItem("cokes", 1));
            Result.Add(new InventoryItem("goldingot", 2));
        }
    }
}
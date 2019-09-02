using PhentrixGames.NewColonyAPI.Recipe;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.NewRecipes
{
    [NCAPIPowerRecipe]
    public class SteelIngots : BaseRecipe
    {
        public SteelIngots() : base("electricforge.steelingot", "phentrixgames.electricforge", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironwrought", 3));
            Requirements.Add(new InventoryItem("cokes", 1));
            Result.Add(new InventoryItem("steelingot", 2));
        }
    }
}
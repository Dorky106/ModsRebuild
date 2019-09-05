using PhentrixGames.NewColonyAPI.Recipe;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.NewRecipes
{
    [NCAPIPowerRecipe]
    public class IronIngots : BaseRecipe
    {
        public IronIngots() : base("electricforge.ironingot", "phentrixgames.electricforge", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("ironore", 2));
            Requirements.Add(new InventoryItem("charcoal", 1));
            Result.Add(new InventoryItem("ironingot", 2));
        }
    }
}
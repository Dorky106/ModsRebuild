using PhentrixGames.NewColonyAPI.Recipe;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.NewRecipes
{
    [NCAPIPowerRecipe]
    public class GalenaLeadIngots : BaseRecipe
    {
        public GalenaLeadIngots() : base("electricforge.galenalead", "phentrixgames.electricforge", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("galenalead", 2));
            Requirements.Add(new InventoryItem("charcoal", 1));
            Result.Add(new InventoryItem("lead", 2));
        }
    }
}
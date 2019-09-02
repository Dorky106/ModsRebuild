using PhentrixGames.NewColonyAPI.Recipe;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.NewRecipes
{
    [NCAPIPowerRecipe]
    public class GalenaSilverIngots : BaseRecipe
    {
        public GalenaSilverIngots() : base("electricforge.galenasilver", "phentrixgames.electricforge", true, 10, 1)
        {
            Requirements.Add(new InventoryItem("galenasilver", 2));
            Requirements.Add(new InventoryItem("charcoal", 1));
            Result.Add(new InventoryItem("silveringot", 2));
            Result.Add(new InventoryItem("crystal", 1));
        }
    }
}
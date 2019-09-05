using PhentrixGames.NewColonyAPI.Recipe;
using static PhentrixGames.NewColonyAPI.Power.PowerManager;

namespace PhentrixGames.RiseoftheNewColonies.NewRecipes
{
    [NCAPIPowerRecipe]
    public class CopperDustRecipe : BaseRecipe
    {
        public CopperDustRecipe() : base("stonecrusher.copperdust", "phentrixgames.stonecrusher", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1000));
            Result.Add(new InventoryItem("copper", 6));
        }
    }

    [NCAPIPowerRecipe]
    public class IronDustRecipe : BaseRecipe
    {
        public IronDustRecipe() : base("stonecrusher.irondust", "phentrixgames.stonecrusher", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("stonebricks", 1000));
            Result.Add(new InventoryItem("ironore", 6));
        }
    }
}
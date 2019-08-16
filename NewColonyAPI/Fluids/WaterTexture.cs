using PhentrixGames.NewColonyAPI.Textures;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;

namespace PhentrixGames.NewColonyAPI.Fluids
{
    [NCAPITexture]
    public class Water : BaseTexture
    {
        public Water() :
            base("greatwater",
                Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModMaterialsDirectory, "albedo", "water.png"),
                Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModMaterialsDirectory, "emissive", "water.png"),
                Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModMaterialsDirectory, "height", "water.png"),
                Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModMaterialsDirectory, "normal", "water.png"))
        { }
    }
}
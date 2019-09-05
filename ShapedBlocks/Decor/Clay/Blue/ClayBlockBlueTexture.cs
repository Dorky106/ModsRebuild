using PhentrixGames.NewColonyAPI.Textures;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPITexture]
    public class ClayBlockBlueTexture : BaseTexture
    {
        public ClayBlockBlueTexture() : base("clayblockblue", PhentrixGames.NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "albedo", "clayblockblue.png"))
        { }
    }
}
using PhentrixGames.NewColonyAPI.Textures;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPITexture]
    public class ClayBlockGreenTexture : BaseTexture
    {
        public ClayBlockGreenTexture() : base("clayblockgreen", PhentrixGames.NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "albedo", "clayblockgreen.png"))
        { }
    }
}
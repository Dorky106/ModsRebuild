using PhentrixGames.NewColonyAPI.Textures;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPITexture]
    public class ClayBlockGrayTexture : BaseTexture
    {
        public ClayBlockGrayTexture() : base("clayblockgray", PhentrixGames.NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "albedo", "clayblockgray.png"))
        { }
    }
}
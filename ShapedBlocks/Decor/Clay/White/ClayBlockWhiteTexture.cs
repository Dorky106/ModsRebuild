using PhentrixGames.NewColonyAPI.Textures;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPITexture]
    public class ClayBlockWhiteTexture : BaseTexture
    {
        public ClayBlockWhiteTexture() : base("clayblockwhite", PhentrixGames.NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "albedo", "clayblockwhite.png"))
        { }
    }
}
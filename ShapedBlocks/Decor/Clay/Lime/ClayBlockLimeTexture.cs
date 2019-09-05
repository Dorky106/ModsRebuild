using PhentrixGames.NewColonyAPI.Textures;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;

namespace PhentrixGames.ShapedBlocks.Decor.Clay.Black
{
    [NCAPITexture]
    public class ClayBlockLimeTexture : BaseTexture
    {
        public ClayBlockLimeTexture() : base("clayblocklime", PhentrixGames.NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "albedo", "clayblocklime.png"))
        { }
    }
}
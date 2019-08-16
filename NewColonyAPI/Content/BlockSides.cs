using PhentrixGames.NewColonyAPI.Textures;

namespace PhentrixGames.NewColonyAPI.Content
{
    [TextureManager.NCAPITexture]
    public class XM : BaseTexture
    {
        public XM() : base("XM", Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModMaterialsDirectory, "albedo", "x-.png"))
        {
        }
    }

    [TextureManager.NCAPITexture]
    public class XP : BaseTexture
    {
        public XP() : base("XP", Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModMaterialsDirectory, "albedo", "x+.png"))
        {
        }
    }

    [TextureManager.NCAPITexture]
    public class ZM : BaseTexture
    {
        public ZM() : base("ZM", Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModMaterialsDirectory, "albedo", "z-.png"))
        {
        }
    }

    [TextureManager.NCAPITexture]
    public class ZP : BaseTexture
    {
        public ZP() : base("ZP", Helpers.Utilities.MultiCombine(NewColonyAPIEntry.ModMaterialsDirectory, "albedo", "z+.png"))
        {
        }
    }
}
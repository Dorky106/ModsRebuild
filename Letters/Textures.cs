using PhentrixGames.NewColonyAPI.Textures;
using static PhentrixGames.NewColonyAPI.Textures.TextureManager;

namespace PhentrixGames.Letters
{
    [NCAPITexture]
    public class ColouredLetters : BaseTexture
    {
        public ColouredLetters() : base("ColouredLetters",
            NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "albedo", "letter.png"),
            null,
            NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "heightsmoothnessspecularity", "letter.png")
            )
        { }
    }

    [NCAPITexture]
    public class ColouredLettersLit : BaseTexture
    {
        public ColouredLettersLit() : base("ColouredLettersLit",
            NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "albedo", "letter.png"),
            NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "emissive", "letter.png"),
            NewColonyAPI.Helpers.Utilities.MultiCombine(Entry.ModMaterialsDirectory, "heightsmoothnessspecularity", "letter.png")
            )
        { }
    }
}
using PhentrixGames.NewColonyAPI.Helpers;
using PhentrixGames.NewColonyAPI.Recipe;
using PhentrixGames.NewColonyAPI.Types;
using static PhentrixGames.NewColonyAPI.Recipe.RecipeManager;
using static PhentrixGames.NewColonyAPI.Types.TypesManager;

namespace PhentrixGames.ShapedBlocks.Decor
{
    [NCAPIRecipe]
    public class clayblocklightblueupsidedowncurvecornerRecipe : BaseRecipe
    {
        public clayblocklightblueupsidedowncurvecornerRecipe() : base("clayblocklightblueupsidedowncurvecornerrecipe", "pipliz.stonemason", false, 10, 1)
        {
            Requirements.Add(new InventoryItem("clay", 1));
            Result.Add(new InventoryItem("clayblocklightblueupsidedowncurvecorner", 1));
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedowncurvecorner : DecorativeType
    {
        public clayblocklightblueupsidedowncurvecorner() : base("clayblocklightblue", "upsidedowncurvecorner",
            Utilities.MultiCombine(Entry.ModIconDirectory, "clayblocklightblueupsidedowncurvecorner.png"))
        {
            this.SideAll = "clayblocklightblue";
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedowncurvecornerXMinus : DecorativeTypeXMinus
    {
        public clayblocklightblueupsidedowncurvecornerXMinus() : base("clayblocklightblue", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedowncurvecornerXPlus : DecorativeTypeXPlus
    {
        public clayblocklightblueupsidedowncurvecornerXPlus() : base("clayblocklightblue", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerx+");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedowncurvecornerZMinus : DecorativeTypeZMinus
    {
        public clayblocklightblueupsidedowncurvecornerZMinus() : base("clayblocklightblue", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz-");
        }
    }

    [NCAPIType]
    public class clayblocklightblueupsidedowncurvecornerZPlus : DecorativeTypeZPlus
    {
        public clayblocklightblueupsidedowncurvecornerZPlus() : base("clayblocklightblue", "upsidedowncurvecorner", Entry.ModName)
        {
            this.Colliders = Collider.GetColliders("upsidedowncurvecornerz+");
        }
    }
}
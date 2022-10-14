using Terraria.ID;
using Terraria.ModLoader;

namespace Eternity
{
    public class Placeholder: ModItem
    {
        public override string Texture => "Eternity/Placeholder";
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Placeholder");
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
        }
    }
}
using Terraria.ID;
using Terraria.ModLoader;

namespace StoneTools.Items
{
    public class PetRock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pet Rock");
            Tooltip.SetDefault("You are now the owner of a genuine, pedigreed pet rock.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 0;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = ModContent.TileType<Tiles.PetRock>();
            item.placeStyle = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
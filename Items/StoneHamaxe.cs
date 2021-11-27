using Terraria.ID;
using Terraria.ModLoader;

namespace StoneTools.Items
{
    public class StoneHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Hamaxe");
            Tooltip.SetDefault("A handy tool that combines the power of axes and hammers together.");
        }

        public override void SetDefaults()
        {
            item.damage = 4;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 28;
            item.useAnimation = 28;
            item.hammer = 35;
            item.axe = 8;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 5;
            item.value = 0; // Coin value in copper
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes() //write recipes
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<StoneAxe>(), 1);
            recipe.AddIngredient(ModContent.ItemType<StoneHammer>(), 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
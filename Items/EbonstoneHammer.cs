using Terraria.ID;
using Terraria.ModLoader;

namespace StoneTools.Items
{
    public class EbonstoneHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ebonstone Hammer");
            Tooltip.SetDefault("A hammer that has been turned corrupt.");
        }

        public override void SetDefaults()
        {
            item.damage = 7;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 30;
            item.useAnimation = 30;
            item.hammer = 40;
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
            recipe.AddIngredient(ItemID.EbonstoneBlock, 10);  //for multiple ingredients restate AddIngredient
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
using Terraria.ID;
using Terraria.ModLoader;

namespace StoneTools.Items
{
    public class StoneHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Hammer");
            Tooltip.SetDefault("A simple but sturdy hammer.");
        }

        public override void SetDefaults()
        {
            item.damage = 4;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 32;
            item.useAnimation = 32;
            item.hammer = 35;
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
            recipe.AddIngredient(ItemID.StoneBlock, 10);  //for multiple ingredients restate AddIngredient
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
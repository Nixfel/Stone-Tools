using Terraria.ID;
using Terraria.ModLoader;

namespace StoneTools.Items
{
    public class StoneAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Axe");
            Tooltip.SetDefault("A simple axe made of stone.");
        }

        public override void SetDefaults()
        {
            item.damage = 4;
            item.melee = true;
            item.width = 40;
            item.height = 35;
            item.useTime = 28;
            item.useAnimation = 28;
            item.axe = 8;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 4;
            item.value = 0; // Coin value in copper
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes() //write recipes
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 8);  //for multiple ingredients restate AddIngredient
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
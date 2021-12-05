using Terraria.ID;
using Terraria.ModLoader;

namespace StoneTools.Items
{
    public class EbonstoneAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ebonstone Axe");
            Tooltip.SetDefault("An axe made of corrupt stone.");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.melee = true;
            item.width = 40;
            item.height = 35;
            item.useTime = 27;
            item.useAnimation = 27;
            item.axe = 9;
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
            recipe.AddIngredient(ItemID.EbonstoneBlock, 8);  //for multiple ingredients restate AddIngredient
            recipe.AddIngredient(ItemID.Wood, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
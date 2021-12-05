using Terraria.ID;
using Terraria.ModLoader;

namespace StoneTools.Items
{
    public class EbonstonePickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ebonstone Pickaxe");
            Tooltip.SetDefault("A basic pickaxe that has become corrupt.");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.pick = 40; // pickaxe power 
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 2;
            item.value = 0; // Coin value in copper
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes() //write recipes
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 12); //for multiple ingredients restate AddIngredient
            recipe.AddIngredient(ItemID.Wood, 4);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
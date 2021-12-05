using Terraria.ID;
using Terraria.ModLoader;

namespace StoneTools.Items
{
    public class CrimstoneBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crimstone Bow");
            Tooltip.SetDefault("A stone bow that has been turned crimson.");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 28;
            item.useAnimation = 28;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 0; // Coin value in copper
            item.rare = ItemRarityID.White;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 16f;
            item.useAmmo = AmmoID.Arrow;
        }

        public override void AddRecipes() //write recipes
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 7);  //for multiple ingredients restate AddIngredient
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
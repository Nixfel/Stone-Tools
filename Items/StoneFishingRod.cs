using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StoneTools.Items
{
    public class StoneFishingRod : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Fishing Rod");
            Tooltip.SetDefault("A simple and sturdy fishing rod, carved from stone.");

            // allows pole to fish in lava
            ItemID.Sets.CanFishInLava[item.type] = true;
        }

        public override void SetDefaults()
        {

            // Clones defaults of Reinforced Fishing Rod
            item.CloneDefaults(ItemID.ReinforcedFishingPole);

            item.fishingPole = 10;
            item.shootSpeed = 12f;
            item.shoot = ProjectileID.BobbersittingDuck;
        }

        public override void HoldItem(Player player)
        {
            player.accFishingLine = true;
        }

        public override void AddRecipes() //write recipes
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 8);  //for multiple ingredients restate AddIngredient
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
using Terraria.ID;
using Terraria.ModLoader;

namespace StoneTools.Items
{
	public class CrimstoneSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimstone Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Basically a really pointy piece of crimstone.");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 21;
			item.useAnimation = 21;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5;
			item.value = 0;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace dynamitegun.Items
{
	public class fastgun : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ultimate Fast Gun");
			Tooltip.SetDefault("The strongest gun in the game. \nEndless musket pouch is recommended.");
		}

		public override void SetDefaults() {
			item.damage = 1000;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes() {
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(22, 10);
			recipe1.AddIngredient(ItemID.Minishark, 1);
			recipe1.AddTile(TileID.WorkBenches);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(704, 10);
			recipe2.AddIngredient(ItemID.Minishark, 1);
			recipe2.AddTile(TileID.WorkBenches);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
		}
	}
}

using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace dynamitegun.Items
{
	public class dynamitegun : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dynamite Gun");
			Tooltip.SetDefault("The strongest gun in the game. \nAutomatically converts normal bullets to dynamite.\nEndless musket pouch is recommended.");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Dynamite, 10);
			recipe.AddIngredient(ItemID.Minishark, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet)
			{
				type = 470;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}
	}
}

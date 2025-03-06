using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace AdvancedAccessoryCombinations.Items.UltimateDivingGear{
	public sealed class UltimateDivingGear : ModItem{
		public static readonly string InlineWikiLibValue = @"
		## Ultimate Diving Gear ![AdvancedAccessoryCombinations/Items/UltimateDivingGear]t4

		The Ultimate Diving Gear Grants	the mobility and effects of Artic Diving Gear, Water Walking Boots, Neptune Shell";

		public override void SetStaticDefaults(){
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults(){
			Item.accessory = true;
			Item.width = 30;
			Item.height = 20;
			Item.value = Item.sellPrice(0, 17, 50, 0);
			Item.rare = ItemRarityID.Pink;
			Item.stack = 1;
		}

		public override void UpdateAccessory(Player player, bool hideVisual){
			player.accFlipper = true;
			player.gills = true;
			player.iceSkate = true;
			player.waterWalk = true;
			if (player.wet){
				Lighting.AddLight(player.Center, 0.6f, 1.5f, 2.5f); // Adds a blue glow
				player.merman = true;
			}
		}

		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.ArcticDivingGear);
			recipe.AddIngredient(ItemID.WaterWalkingBoots);
			recipe.AddIngredient(ItemID.NeptunesShell);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
		}
	}
}

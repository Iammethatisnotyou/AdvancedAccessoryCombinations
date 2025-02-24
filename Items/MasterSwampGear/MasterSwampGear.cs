using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

//namespace AdvancedAccessoryCombinations.Items.MasterNinjaFrogGear

namespace AdvancedAccessoryCombinations.Items.MasterSwampGear{
	//namespace AdvancedAccessoryCombinations.Items.MasterNinjaFrogGear

	public sealed class MasterSwampGear : ModItem{
		public static readonly string InlineWikiLibValue = @"
## Master Swamp Gear ![AdvancedAccessoryCombinations/Items/MasterSwampGear]t4

The Master Swamp Gear Grants the affects of Master Ninja Frog Gear with Water Walking Boots";

		public override void SetStaticDefaults(){
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults(){
		    Item.accessory = true;
		    Item.width = 30;
		    Item.height = 30;
		    Item.value = Item.sellPrice(0, 16, 0, 0);
		    Item.rare = ItemRarityID.Orange;
		    Item.stack = 1;
		}

		public override void UpdateAccessory(Player player, bool hideVisual){
			// Master Ninja Gear
			player.dashType = 1;
			player.blackBelt = true;
			player.spikedBoots = 2;

			// Frog gear
			player.accFlipper = true;
			player.autoJump = true;
			player.jumpBoost = true;
			player.jumpSpeedBoost += 2.4f;

			player.waterWalk = true;
		}

		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			//recipe.AddIngredient(ModContent.ItemType<MasterNinjaFrogGear>());
			recipe.AddIngredient(ModContent.ItemType<AdvancedAccessoryCombinations.Items.MasterNinjaFrogGear.MasterNinjaFrogGear>());
			//recipe.AddIngredient<MasterNinjaFrogGear.MasterNinjaFrogGear();
			recipe.AddIngredient(ItemID.WaterWalkingBoots);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
        	}
	}
}

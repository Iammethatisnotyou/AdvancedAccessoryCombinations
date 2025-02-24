using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace AdvancedAccessoryCombinations.Items.MasterNinjaFrogGear{
	public sealed class MasterNinjaFrogGear : ModItem{
		public static readonly string InlineWikiLibValue = @"
		## Master Ninja Frog Gear

		The **Master Ninja Frog Gear** combines the effects of the **Master Ninja Gear** and **Frog Gear**. 
		It grants increased mobility, dash abilities, and jump enhancements.

		### Effects:
		- Grants **Master Ninja Gear** abilities (dash, black belt, spiked boots)
		- Grants **Frog Gear** abilities (flipper, auto-jump, jump boost)

		![Master Ninja Frog Gear](Images/MasterNinjaFrogGear.png)  // Image path for wiki
		";


		public override void SetStaticDefaults(){
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults(){
		    Item.accessory = true;
		    Item.width = 30;
		    Item.height = 30;
		    Item.value = Item.sellPrice(0, 12, 0, 0);
		    Item.rare = ItemRarityID.LightPurple;
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
		}

		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.MasterNinjaGear);
			recipe.AddIngredient(ItemID.FrogLeg);
			recipe.AddIngredient(ItemID.Flipper);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
        	}
	}
}

using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace AdvancedAccessoryCombinations.Items.TerraAmphibianBoots{
	public sealed class TerraAmphibianBoots : ModItem{
		public static readonly string InlineWikiLibValue = @"
## TerraAmphibianBoots ![AdvancedAccessoryCombinations/Items/TerraAmphibianBoots]t4

The Terra Amphibian Boots Band Grants Super fast running with everything in the terra spark boots
and the jump boost of frog leg.";

		public override void SetStaticDefaults(){
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults(){
		    Item.accessory = true;
		    Item.width = 34;
		    Item.height = 32;
		    Item.value = Item.sellPrice(0, 16);
		    Item.rare = ItemRarityID.Lime;
		    Item.stack = 1;
		}

		public override void UpdateAccessory(Player player, bool hideVisual){
			// Frostspark
			player.accRunSpeed = 6.75f;
			player.runAcceleration *= 1.08f;
			player.rocketBoots = 3;
			player.moveSpeed += 0.08f;
			player.iceSkate = true;

			// Lava Waders
			player.waterWalk = true;
			player.fireWalk = true;
			player.lavaImmune = true;
			player.ignoreWater = true;

			player.jumpBoost = true;
			player.jumpSpeedBoost += 2.4f;

		}

		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.TerrasparkBoots);
			recipe.AddIngredient(ItemID.FrogLeg);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
        	}
	}
}

using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace AdvancedAccessoryCombinations.Items.HardenedBand{
	public sealed class HardenedBand : ModItem{
		public static readonly string InlineWikiLibValue = @"
## Hardened Band ![AdvancedAccessoryCombinations/Items/HardenedBand]t4

The Hardened Band Grants Increased regeneration, 25% potion cool down and 1 defense.
";

		public override void SetStaticDefaults(){
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults(){
		    Item.accessory = true;
		    Item.width = 30;
		    Item.height = 20;
		    Item.value = Item.sellPrice(0, 4, 20, 0);
		    Item.rare = ItemRarityID.Orange;
		    Item.stack = 1;
		}

		public override void UpdateAccessory(Player player, bool hideVisual){
		    player.statDefense += 1;
		    player.lifeRegen += 1;
		    player.pStone = true;
		}

		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CharmofMyths);
			recipe.AddIngredient(ItemID.Shackle);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
        	}
	}
}

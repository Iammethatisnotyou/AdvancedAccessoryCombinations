using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace AdvancedAccessoryCombinations.Items.BrainScarf{
	public sealed class BrainScarf : ModItem{
		public static readonly string InlineWikiLibValue = @"
		## Brain Scarf

		The **Brain Scarf** combines the effects of the **Brain Of Confusion** and **Worm Scarf**. 
		It grants increased mobility, dash abilities, and jump enhancements.

		![Brain Scarf](Items/BrainScarf.png)  // Image path for wiki
		";


		public override void SetStaticDefaults(){
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults(){
		    Item.accessory = true;
		    Item.width = 28;
		    Item.height = 28;
		    Item.value = Item.sellPrice(0, 5);
		    Item.rare = ItemRarityID.Expert;
		    Item.stack = 1;
		}

		public override void UpdateAccessory(Player player, bool hideVisual){
			player.jumpSpeedBoost += 2.4f;
			player.endurance += 0.17f;
		}

		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.BrainOfConfusion);
			recipe.AddIngredient(ItemID.WormScarf);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
        	}
	}
}

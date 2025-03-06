using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace AdvancedAccessoryCombinations.Items.FrozenHeroShield{
	public sealed class FrozenHeroShield : ModItem{
		public static readonly string InlineWikiLibValue = @"
## Frozen Hero Shield ![AdvancedAccessoryCombinations/Items/FrozenHeroShield]t4

The Frozen Hero Shield Grants 10 defense, increased aggro, a frozen barrier buff under 50% and no knockback.";

		public override void SetStaticDefaults(){
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults(){
		    Item.accessory = true;
		    Item.width = 36;
		    Item.height = 38;
		    Item.value = Item.sellPrice(0, 18);
		    Item.rare = ItemRarityID.Pink;
		    Item.stack = 1;
		    Item.defense = 10;
		}

		public override void UpdateAccessory(Player player, bool hideVisual){
			player.statDefense += 14;
			player.noKnockback = true;
			player.hasPaladinShield = true;
			player.aggro += 400;
			if (player.statLife <= player.statLifeMax2 / 2 ) {
				player.AddBuff(BuffID.IceBarrier, 2);
			}
		}

		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.FleshKnuckles);
			recipe.AddIngredient(ItemID.FrozenTurtleShell);
			recipe.AddIngredient(ItemID.PaladinsShield);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
        	}
	}
}

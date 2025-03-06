using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace AdvancedAccessoryCombinations.Items.ObsidianCthulhuShield{
	public sealed class ObsidianCthulhuShield : ModItem{
		public static readonly string InlineWikiLibValue = @"
## Obsidian Cthulhu Shield ![AdvancedAccessoryCombinations/Items/ObsidianCthulhuShield]t4

The Obsidian Cthulhu Shield Grants a dash ability and immunity to lava and no knockback.
";

		public override void SetStaticDefaults(){
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults(){
		    Item.accessory = true;
		    Item.width = 30;
		    Item.height = 32;
		    Item.value = Item.sellPrice(0, 5);
		    Item.rare = ItemRarityID.Expert;
		    Item.stack = 1;
		    Item.defense = 4;
		    Item.noMelee = false;
		    Item.damage = 30;
		    Item.knockBack = 9f;
		    Item.DamageType = DamageClass.Default;
		}

		public override void UpdateAccessory(Player player, bool hideVisual){
			player.dashType = 2;

			player.noKnockback = true;
			player.fireWalk = true;
		}

		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.EoCShield);
			recipe.AddIngredient(ItemID.ObsidianShield);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
        	}
	}
}

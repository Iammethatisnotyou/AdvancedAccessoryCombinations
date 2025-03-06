using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace AdvancedAccessoryCombinations.Items.SlimeShield{
	public sealed class SlimeShield : ModItem{
		public static readonly string InlineWikiLibValue = @"
## Slime Shield ![AdvancedAccessoryCombinations/Items/SlimeShield]t4

The Slime Shield Grants Allows the player to dash into the enemy and grants immunity to slimes.";
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
		    Item.defense = 2;
		    Item.noMelee = false;
		    Item.damage = 30;
		    Item.knockBack = 9f;
		    Item.DamageType = DamageClass.Melee;
		}
		public static int ItemType() => ModContent.ItemType<SlimeShield>();

		public override void UpdateAccessory(Player player, bool hideVisual){
			player.dashType = 2;

			player.npcTypeNoAggro[NPCID.BlueSlime] = true;
			player.npcTypeNoAggro[NPCID.SpikedIceSlime] = true;
			player.npcTypeNoAggro[NPCID.SpikedJungleSlime] = true;
			player.npcTypeNoAggro[NPCID.SlimeSpiked] = true;
			player.npcTypeNoAggro[NPCID.ToxicSludge] = true;
			player.npcTypeNoAggro[NPCID.MotherSlime] = true;
			player.npcTypeNoAggro[NPCID.LavaSlime] = true;
			player.npcTypeNoAggro[NPCID.DungeonSlime] = true;
			player.npcTypeNoAggro[NPCID.IlluminantSlime] = true;
			player.npcTypeNoAggro[NPCID.CorruptSlime] = true;
			player.npcTypeNoAggro[NPCID.Crimslime] = true;
		}

		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.EoCShield);
			recipe.AddIngredient(ItemID.RoyalGel);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
        	}
	}
}

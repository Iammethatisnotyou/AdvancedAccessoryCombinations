using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace AdvancedAccessoryCombinations.Items.CelestialAnkh{
	public sealed class CelestialAnkh : ModItem{
		public static readonly string InlineWikiLibValue = @"
## CelestialAnkh Band ![AdvancedAccessoryCombinations/Items/CelestialAnkh]t4

The Celestial Ankh Grants the immunities of the Ankh Shield and abilities of the Celestial Shell.
";

		public override void SetStaticDefaults(){
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults(){
		    Item.accessory = true;
		    Item.width = 30;
		    Item.height = 34;
		    Item.value = Item.sellPrice(0, 20);
		    Item.rare = ItemRarityID.Orange;
		    Item.stack = 1;
		}

		public override void UpdateAccessory(Player player, bool hideVisual){
			// Ankh Shield effects
			player.buffImmune[BuffID.Poisoned] = true;
			player.buffImmune[BuffID.Cursed] = true;
			player.buffImmune[BuffID.Bleeding] = true;
			player.buffImmune[BuffID.Confused] = true;
			player.buffImmune[BuffID.WitheredArmor] = true;
			player.buffImmune[BuffID.WitheredWeapon] = true;
			player.buffImmune[BuffID.Electrified] = true;
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Frostburn] = true;
			player.buffImmune[BuffID.Venom] = true;
			player.buffImmune[BuffID.Shine] = true;
			player.buffImmune[BuffID.Lovestruck] = true;
			
			if (player.wet){
				player.merman = true;
			}
			else if (Main.dayTime){
				player.statLifeMax2 += 5;
				player.statManaMax2 += 20;
				player.lifeRegen += 4;
				player.manaRegen += 2;
			}
			else{
				player.statLifeMax2 += 5; // maximum health += 5
				player.statManaMax2 += 20; // maximum mana += 20
				player.lifeRegen += 2;
				player.manaRegen += 2;
				player.moveSpeed += 0.2f;
				player.GetDamage(DamageClass.Melee) += 0.15f;
				player.GetDamage(DamageClass.Ranged) += 0.15f;
				player.GetDamage(DamageClass.Magic) += 0.15f;
				player.GetDamage(DamageClass.Summon) += 0.15f;
			}
			
		}

		public override void AddRecipes(){
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.AnkhShield);
			recipe.AddIngredient(ItemID.CelestialShell);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.Register();
        	}
	}
}

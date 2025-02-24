using Terraria.ModLoader;

namespace AdvancedAccessoryCombinations
{
    public class AdvancedAccessoryCombinations : Mod
    {
	public static AdvancedAccessoryCombinations Instance;
        public override void Load()
        {
            base.Load();
        }

        public override void Unload()
        {
		Logger.Info("Unloading Advanced Accessory Combinations");
        	base.Unload();
        }
    }
}

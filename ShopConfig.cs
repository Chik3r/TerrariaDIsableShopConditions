using System.ComponentModel;
using DisableShopConditions.ConfigData;
using Terraria.ModLoader.Config;

namespace DisableShopConditions; 

public class ShopConfig : ModConfig {
    public override ConfigScope Mode => ConfigScope.ServerSide;

    [Header("BiomeConditions")]
    [DefaultValue(true)]
    [ReloadRequired]
    public bool DisableBiomeConditions;

    [ReloadRequired]
    [Expand(false)]
    public BiomeConditions SpecificBiomeConditions = new();
}
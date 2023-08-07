using System;
using System.ComponentModel;
using System.Linq;
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

    public ShopConditions? ShopConditionFromType(Type type) => 
        GetType().GetFields().FirstOrDefault(x => x.GetType() == type)?.GetValue(this) as ShopConditions;
}
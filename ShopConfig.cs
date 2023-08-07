using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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
        GetType().GetFields(BindingFlags.Instance | BindingFlags.Public)
        .FirstOrDefault(x => x.FieldType == type)?.GetValue(this) as ShopConditions;
}
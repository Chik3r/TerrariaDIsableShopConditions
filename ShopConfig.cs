using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using DisableShopConditions.ConfigData;
using Newtonsoft.Json;
using Terraria.ModLoader.Config;

namespace DisableShopConditions; 

public class ShopConfig : ModConfig {
    public override ConfigScope Mode => ConfigScope.ServerSide;

    [Header("BiomeConditions")]
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.SetAllTooltip")]
    [ReloadRequired]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool DisableBiomeConditions {
        get => SpecificBiomeConditions?.AllConditionsDisabled() ?? false;
        set => SpecificBiomeConditions.SetAllConditions(value);
    }

    [ReloadRequired]
    [Expand(false)]
    public BiomeConditions SpecificBiomeConditions { get; set; } = new();
    
    //////////////////////////////////////////////////////////////////////////////
    
    [Header("WorldFlagConditions")]
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.SetAllTooltip")]
    [ReloadRequired]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool DisableWorldFlagConditions {
        get => SpecificWorldFlagConditions?.AllConditionsDisabled() ?? false;
        set => SpecificWorldFlagConditions.SetAllConditions(value);
    }

    [ReloadRequired]
    [Expand(false)]
    public WorldFlagConditions SpecificWorldFlagConditions { get; set; } = new();
    
    //////////////////////////////////////////////////////////////////////////////
    
    [Header("WorldTypeConditions")]
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.SetAllTooltip")]
    [ReloadRequired]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool DisableWorldTypeConditions {
        get => SpecificWorldTypeConditions?.AllConditionsDisabled() ?? false;
        set => SpecificWorldTypeConditions.SetAllConditions(value);
    }

    [ReloadRequired]
    [Expand(false)]
    public WorldTypeConditions SpecificWorldTypeConditions { get; set; } = new();
    
    //////////////////////////////////////////////////////////////////////////////
    
    [Header("WorldTypeConditions")]
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.SetAllTooltip")]
    [ReloadRequired]
    [JsonIgnore]
    [ShowDespiteJsonIgnore]
    public bool DisableEventConditions {
        get => SpecificEventConditions?.AllConditionsDisabled() ?? false;
        set => SpecificEventConditions.SetAllConditions(value);
    }

    [ReloadRequired]
    [Expand(false)]
    public EventConditions SpecificEventConditions { get; set; } = new();

    public ShopConditions? ShopConditionFromType(Type type) => 
        GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
        .FirstOrDefault(x => x.PropertyType == type)?.GetValue(this) as ShopConditions;
}
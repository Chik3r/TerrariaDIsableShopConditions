using Terraria.ModLoader.Config;

namespace DisableShopConditions.ConfigData; 

public class BiomeConditions : ShopConditions {
    public BiomeConditions(bool value = true) : base(value) { }
    public BiomeConditions() : base(true) {}

    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InDungeon;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InCorrupt;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InHallow;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InMeteor;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InJungle;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InSnow;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InCrimson;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InWaterCandle;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InPeaceCandle;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InTowerSolar;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InTowerVortex;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InTowerNebula;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InTowerStardust;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InDesert;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InGlowshroom;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InUndergroundDesert;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InSkyHeight;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InSpace;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InOverworldHeight;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InDirtLayerHeight;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InRockLayerHeight;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InUnderworldHeight;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InUnderworld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InBeach;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InRain;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InSandstorm;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InOldOneArmy;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InGranite;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InMarble;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InHive;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InGemCave;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InLihzhardTemple;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InGraveyard;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool InAether;
}
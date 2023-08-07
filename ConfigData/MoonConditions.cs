using Terraria.ModLoader.Config;

namespace DisableShopConditions.ConfigData; 

public class MoonConditions : ShopConditions {
    public MoonConditions() : base(false) { }
    
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhaseFull;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhaseWaningGibbous;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhaseThirdQuarter;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhaseWaningCrescent;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhaseNew;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhaseWaxingCrescent;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhaseFirstQuarter;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhaseWaxingGibbous;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhasesQuarter0;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhasesQuarter1;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhasesQuarter2;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhasesQuarter3;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhasesHalf0;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhasesHalf1;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhasesEven;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhasesOdd;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhasesNearNew;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhasesEvenQuarters;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhasesOddQuarters;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhases04;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhases15;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhases26;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool MoonPhases37;
}
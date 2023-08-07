using Terraria.ModLoader.Config;

namespace DisableShopConditions.ConfigData; 

public class EventConditions : ShopConditions {
    public EventConditions() : base(false) { }
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool Christmas;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool Halloween;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool BloodMoon;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotBloodMoon;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool Eclipse;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotEclipse;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool EclipseOrBloodMoon;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotEclipseAndNotBloodMoon;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool Thunderstorm;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool BirthdayParty;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool LanternNight;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool HappyWindyDay;
}
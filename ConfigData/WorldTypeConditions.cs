using Terraria.ModLoader.Config;

namespace DisableShopConditions.ConfigData; 

public class WorldTypeConditions : ShopConditions {
    public WorldTypeConditions() : base(false) { }

    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool DrunkWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool RemixWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotTheBeesWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool ForTheWorthyWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool TenthAnniversaryWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool DontStarveWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NoTrapsWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool ZenithWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotDrunkWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotRemixWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotNotTheBeesWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotForTheWorthy;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotTenthAnniversaryWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotDontStarveWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotNoTrapsWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NotZenithWorld;
}
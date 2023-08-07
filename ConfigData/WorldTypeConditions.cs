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
}
using Terraria.ModLoader.Config;

namespace DisableShopConditions.ConfigData; 

public class MiscConditions : ShopConditions {
    public MiscConditions() : base(false) { }
    
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool BloodMoonOrHardmode;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool NightOrEclipse;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool Multiplayer;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool HappyEnough;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool HappyEnoughToSellPylons;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool AnotherTownNPCNearby;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool IsNpcShimmered;
}
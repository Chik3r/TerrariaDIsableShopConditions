using Terraria.ModLoader.Config;

namespace DisableShopConditions.ConfigData; 

public class WorldFlagConditions : ShopConditions {
    public WorldFlagConditions(bool value = true) : base(value) { }
    public WorldFlagConditions() : base(false) { }
    
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool Hardmode;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool PreHardmode;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool SmashedShadowOrb;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool CrimsonWorld;
    [TooltipKey("$Mods.DisableShopConditions.Configs.Common.BoolTooltip")] public bool CorruptWorld;
}
using System;
using System.Collections.Generic;
using System.Linq;
using DisableShopConditions.ConfigData;
using Terraria;
using Terraria.ModLoader;

namespace DisableShopConditions; 

public class ShopNPC : GlobalNPC {
    private static ShopConfig Config => ModContent.GetInstance<ShopConfig>();
    
    public override void ModifyShop(NPCShop shop) {
        List<Type> shopConditionsTypes = typeof(ShopNPC).Assembly.GetTypes().Where(t => t != typeof(ShopConditions) && typeof(ShopConditions).IsAssignableFrom(t)).ToList();
        List<ShopConditions> shopConditions = new(shopConditionsTypes.Count);
        foreach (Type shopConditionType in shopConditionsTypes) {
            ShopConditions? shopCondition = Config.ShopConditionFromType(shopConditionType);
            if (shopCondition is null) {
                Mod.Logger.Warn($"Shop condition (type: {shopConditionType.FullName}) couldn't be found");
                continue;
            }
            shopConditions.Add(shopCondition);
        }
        
        IReadOnlyList<NPCShop.Entry> shopEntries = shop.Entries;
        foreach (NPCShop.Entry entry in shopEntries) {
            if (entry.Conditions is not List<Condition> conditions) {
                Mod.Logger.Warn("Conditions is not a List<Condition>, please report this to the mod author.");
                continue;
            }
            
            if (conditions.Count == 0) continue;

            foreach (ShopConditions shopCondition in shopConditions) {
                Dictionary<string, bool> disabledConditions = shopCondition.GetDisabledConditions();
                foreach ((string name, bool value) in disabledConditions) {
                    if (!value) continue;
                    
                    Condition? conditionToRemove = ShopConditions.GetConditionFromString(name);
                    if (conditionToRemove is null) {
                        Mod.Logger.Warn("Couldn't find condition: " + name);
                        continue;
                    }
                    
                    if (!conditions.Contains(conditionToRemove) || !value) continue;
                    conditions.Remove(conditionToRemove);
                }
            }
        }
    }
}
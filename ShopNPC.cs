using System;
using System.Collections.Generic;
using System.Linq;
using DisableShopConditions.ConfigData;
using Terraria;
using Terraria.ModLoader;

namespace DisableShopConditions; 

public class ShopNPC : GlobalNPC {
    public override void ModifyShop(NPCShop shop) {
        List<Type> shopConditions = typeof(ShopNPC).Assembly.GetTypes().Where(t => typeof(ShopConditions).IsAssignableFrom(t)).ToList();
        
        
        IReadOnlyList<NPCShop.Entry> shopEntries = shop.Entries;
        foreach (NPCShop.Entry entry in shopEntries) {
            if (entry.Conditions is not List<Condition> conditions) {
                Mod.Logger.Warn("Conditions is not a List<Condition>, please report this to the mod author.");
                continue;
            }

            List<Condition> clone = new(conditions);
            foreach (Condition condition in clone) {
                if (condition == Condition.InGraveyard) {
                    conditions.Remove(condition);
                }
            }
        }
    }
}
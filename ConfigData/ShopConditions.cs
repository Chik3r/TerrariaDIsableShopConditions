using System.Collections.Generic;
using System.Reflection;
using Terraria;

namespace DisableShopConditions.ConfigData; 

public abstract class ShopConditions {
    private static readonly Dictionary<string, Condition?> ConditionStorage = new();
    
    public Dictionary<string, bool> GetDisabledConditions() {
        FieldInfo[] fields = GetType().GetFields();
        Dictionary<string, bool> disabledConditions = new();
        foreach (FieldInfo field in fields) {
            if (field.GetValue(this) is bool value) {
                disabledConditions.Add(field.Name, value);
            }
        }

        return disabledConditions;
    }

    public static Condition? GetConditionFromString(string name) {
        if (ConditionStorage.TryGetValue(name, out Condition? condition)) return condition;
        ConditionStorage[name] = typeof(Condition).GetField(name, BindingFlags.Static | BindingFlags.Public)?.GetValue(null) as Condition;
        
        return ConditionStorage[name];
    }
}
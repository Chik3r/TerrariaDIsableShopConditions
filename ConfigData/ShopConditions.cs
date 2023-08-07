using System.Collections.Generic;
using System.Reflection;

namespace DisableShopConditions.ConfigData; 

public abstract class ShopConditions {
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
}
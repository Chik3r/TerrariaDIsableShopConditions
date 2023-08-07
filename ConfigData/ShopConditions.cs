﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.ModLoader;

namespace DisableShopConditions.ConfigData; 

public abstract class ShopConditions {
    private static readonly Dictionary<string, Condition?> ConditionStorage = new();
    private static readonly Dictionary<Type, FieldInfo[]> TypeFieldsStorage = new();

    private FieldInfo[] FieldsStorage {
        get {
            Type type = GetType();
            if (TypeFieldsStorage.TryGetValue(type, out FieldInfo[]? fields)) return fields;
            TypeFieldsStorage[type] = type.GetFields();
            return TypeFieldsStorage[type];
        }
    }
    
    public Dictionary<string, bool> GetDisabledConditions() {
        FieldInfo[] fields = FieldsStorage;
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

    public override int GetHashCode() {
        FieldInfo[] fields = FieldsStorage;
        int hash = 17;
        foreach (FieldInfo field in fields) {
            hash = hash * 23 + field.GetValue(this)!.GetHashCode();
        }

        return hash;
    }

    public override bool Equals(object? obj) {
        if (obj is null) return false;
        if (obj.GetType() != GetType()) return false;
        
        // Use reflection to check that all fields are equal
        FieldInfo[] fields = FieldsStorage;
        foreach (FieldInfo field in fields) {
            if (field.GetValue(this)?.Equals(field.GetValue(obj)) != true) return false;
        }
        
        return true;
    }
}
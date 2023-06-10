﻿/*ISC License

Copyright (c) 2019, Daan Verstraten */
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DaanV2.NBT; 
public static partial class NBTCasting {
    /// <summary>Converts the given byte to the specified type</summary>
    /// <param name="Value">The value to convert</param>
    /// <param name="To">The type to convert to</param>
    /// <returns>Converts the given byte to the specified type</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Object Convert(Int32[] Value, Type To) {
        if (To == typeof(List<Int32>)) {
            return new List<Int32>(Value);
        }

        return Value;
    }
}

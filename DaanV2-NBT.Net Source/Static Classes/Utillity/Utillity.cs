﻿/*ISC License

Copyright (c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.NBT {
    ///DOLATER <summary> add description for class: Utillity</summary>
    public static partial class Utillity {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<T> GetInterfaces<T>() {
            List<T> Out = new List<T>(10);
            Type Find = typeof(T);
            Assembly[] Assemblies = AppDomain.CurrentDomain.GetAssemblies();
            Int32 AsmLength = Assemblies.Length;
            Type[] Types;
            Type Current;
            Int32 TypesLength;
            Assembly Asm;

            for (Int32 I = 0; I < AsmLength; I++) {
                Asm = Assemblies[I];

                Types = Asm.GetTypes();
                TypesLength = Types.Length;

                for (Int32 J = 0; J < TypesLength; J++) {
                    Current = Types[J];

                    if (Current.GetInterface(Find.Name) != null) {
                        Out.Add((T)Activator.CreateInstance(Current));
                    }
                }
            }

            return Out;
        }
    }
}
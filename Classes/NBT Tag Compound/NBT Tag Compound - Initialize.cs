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
using System.Runtime.Serialization;

namespace DaanV2.NBT {
    ///DOLATER <summary> add description for class: NBTTagCompound</summary>
	[Serializable, DataContract]
    public partial class NBTTagCompound {
        /// <summary>Creates a new instance of <see cref="NBTTagCompound"/></summary>
        public NBTTagCompound() : base(10) { }

        /// <summary>Creates a new instance of <see cref="NBTTagCompound"/></summary>
        /// <param name="Capacity"></param>
        public NBTTagCompound(Int32 Capacity) : base(Capacity) { }

        /// <summary>Creates a new instance of <see cref="NBTTagCompound"/></summary>
        /// <param name="Capacity"></param>
        public NBTTagCompound(String Name, Int32 Capacity) : base(Capacity) {
            this._Name = Name;
        }
    }
}

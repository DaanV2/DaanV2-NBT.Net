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
using System.IO;
using DaanV2.Binary;

namespace DaanV2.NBT.Serialization {
    public static partial class NBTWriter {
        /// <summary>Writes the given nbtstructure into a file</summary>
        /// <param name="Filepath">The filepath to write to</param>
        /// <param name="Tag">The tag to write</param>
        /// <param name="compression">The compression type to be used</param>
        /// <param name="endianness">The endianness of the nbt structure</param>
        public static void WriteFile(String Filepath, ITag Tag, NBTCompression compression, Endianness endianness) {
            FileStream Writer = new FileStream(Filepath, FileMode.Create);

            Stream stream = CompressionStream.GetCompressionStream(Writer, compression);
            Write(Tag, new SerializationContext(endianness, stream));

            stream.Flush();
            stream.Close();
        }

        /// <summary>Writes the given nbtstructure into a file</summary>
        /// <param name="stream">The stream to write to</param>
        /// <param name="Tag">The tag to write</param>
        /// <param name="compression">The compression type to be used</param>
        /// <param name="endianness">The endianness of the nbt structure</param>
        public static void WriteFile(Stream stream, ITag Tag, NBTCompression compression, Endianness endianness) {
            stream = CompressionStream.GetCompressionStream(stream, compression);

            Write(Tag, new SerializationContext(endianness, stream));
        }

        /// <summary>Writes the given nbtstructure into a file</summary>
        /// <param name="Filepath">The filepath to write to</param>
        /// <param name="Tag">The tag to write</param>
        /// <param name="endianness">The endianness of the nbt structure</param>
        public static void WriteFile(String Filepath, ITag Tag, Endianness endianness = Endianness.LittleEndian) {
            FileStream Writer = new FileStream(Filepath, FileMode.Create);
            Write(Tag, new SerializationContext(endianness, Writer));

            Writer.Flush();
            Writer.Close();
        }
    }
}
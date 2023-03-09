﻿// Copyright (c) 2022 The nanoFramework project contributors
// See LICENSE file in the project root for full license information.

namespace Iot.Device.Ssd13xx.Samples
{
    /// <summary>
    /// A font class with every character is 12-points wide and 8-points high.
    /// </summary>
    public class Font8x12 : IFont
    {
        private static readonly byte[][] _fontTable =
        {
            new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, // U+0020 (space)
            new byte[] { 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00 }, // U+0021 (!)
            new byte[] { 0x24, 0x24, 0x24, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, // U+0022 (")
            new byte[] { 0x00, 0x14, 0x14, 0x7f, 0x14, 0x7f, 0x14, 0x14, 0x00, 0x00, 0x00, 0x00 }, // U+0023 (#)
            new byte[] { 0x08, 0x3e, 0x49, 0x09, 0x3e, 0x48, 0x49, 0x3e, 0x08, 0x00, 0x00, 0x00 }, // U+0024 ($)
            new byte[] { 0x02, 0x45, 0x22, 0x10, 0x08, 0x04, 0x22, 0x51, 0x20, 0x00, 0x00, 0x00 }, // U+0025 (%)
            new byte[] { 0x00, 0x04, 0x0a, 0x0a, 0x04, 0x2a, 0x11, 0x11, 0x2e, 0x00, 0x00, 0x00 }, // U+0026 (&)
            new byte[] { 0x02, 0x02, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, // U+0027 (')
            new byte[] { 0x08, 0x04, 0x02, 0x02, 0x02, 0x02, 0x02, 0x04, 0x08, 0x00, 0x00, 0x00 }, // U+0028 (()
            new byte[] { 0x08, 0x10, 0x20, 0x20, 0x20, 0x20, 0x20, 0x10, 0x08, 0x00, 0x00, 0x00 }, // U+0029 ())
            new byte[] { 0x00, 0x08, 0x2a, 0x1c, 0x7f, 0x1c, 0x2a, 0x08, 0x00, 0x00, 0x00, 0x00 }, // U+002A (*)
            new byte[] { 0x00, 0x08, 0x08, 0x08, 0x7f, 0x08, 0x08, 0x08, 0x00, 0x00, 0x00, 0x00 }, // U+002B (+)
            new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x04, 0x02, 0x00 }, // U+002C (,)
            new byte[] { 0x00, 0x00, 0x00, 0x00, 0x7f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, // U+002D (-)
            new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00 }, // U+002E (.)
            new byte[] { 0x00, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01, 0x00, 0x00, 0x00, 0x00 }, // U+002F (/)
            new byte[] { 0x3e, 0x41, 0x61, 0x51, 0x49, 0x45, 0x43, 0x41, 0x3e, 0x00, 0x00, 0x00 }, // U+0030 (0)
            new byte[] { 0x08, 0x0c, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x1c, 0x00, 0x00, 0x00 }, // U+0031 (1)
            new byte[] { 0x3e, 0x41, 0x40, 0x20, 0x18, 0x04, 0x02, 0x01, 0x7f, 0x00, 0x00, 0x00 }, // U+0032 (2)
            new byte[] { 0x3e, 0x41, 0x40, 0x40, 0x3c, 0x40, 0x40, 0x41, 0x3e, 0x00, 0x00, 0x00 }, // U+0033 (3)
            new byte[] { 0x20, 0x30, 0x28, 0x24, 0x22, 0x7f, 0x20, 0x20, 0x20, 0x00, 0x00, 0x00 }, // U+0034 (4)
            new byte[] { 0x7f, 0x01, 0x01, 0x01, 0x3f, 0x40, 0x40, 0x41, 0x3e, 0x00, 0x00, 0x00 }, // U+0035 (5)
            new byte[] { 0x3e, 0x41, 0x01, 0x01, 0x3f, 0x41, 0x41, 0x41, 0x3e, 0x00, 0x00, 0x00 }, // U+0036 (6)
            new byte[] { 0x7f, 0x40, 0x20, 0x10, 0x08, 0x08, 0x08, 0x08, 0x08, 0x00, 0x00, 0x00 }, // U+0037 (7)
            new byte[] { 0x3e, 0x41, 0x41, 0x41, 0x3e, 0x41, 0x41, 0x41, 0x3e, 0x00, 0x00, 0x00 }, // U+0038 (8)
            new byte[] { 0x3e, 0x41, 0x41, 0x41, 0x7e, 0x40, 0x40, 0x41, 0x3e, 0x00, 0x00, 0x00 }, // U+0039 (9)
            new byte[] { 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00 }, // U+003A (:)
            new byte[] { 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x00, 0x04, 0x04, 0x02, 0x00 }, // U+003B (//)
            new byte[] { 0x10, 0x08, 0x04, 0x02, 0x01, 0x02, 0x04, 0x08, 0x10, 0x00, 0x00, 0x00 }, // U+003C (<)
            new byte[] { 0x00, 0x00, 0x00, 0x7f, 0x00, 0x7f, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, // U+003D (=)
            new byte[] { 0x04, 0x08, 0x10, 0x20, 0x40, 0x20, 0x10, 0x08, 0x04, 0x00, 0x00, 0x00 }, // U+003E (>)
            new byte[] { 0x3e, 0x41, 0x41, 0x20, 0x10, 0x08, 0x08, 0x00, 0x08, 0x00, 0x00, 0x00 }, // U+003F (?)
            new byte[] { 0x3e, 0x41, 0x59, 0x55, 0x55, 0x25, 0x1d, 0x41, 0x3e, 0x00, 0x00, 0x00 }, // U+0040 (@)
            new byte[] { 0x1c, 0x22, 0x41, 0x41, 0x7f, 0x41, 0x41, 0x41, 0x41, 0x00, 0x00, 0x00 }, // U+0041 (A)
            new byte[] { 0x3f, 0x41, 0x41, 0x41, 0x3f, 0x41, 0x41, 0x41, 0x3f, 0x00, 0x00, 0x00 }, // U+0042 (B)
            new byte[] { 0x3c, 0x42, 0x01, 0x01, 0x01, 0x01, 0x01, 0x42, 0x3c, 0x00, 0x00, 0x00 }, // U+0043 (C)
            new byte[] { 0x3f, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x3f, 0x00, 0x00, 0x00 }, // U+0044 (D)
            new byte[] { 0x7f, 0x01, 0x01, 0x01, 0x0f, 0x01, 0x01, 0x01, 0x7f, 0x00, 0x00, 0x00 }, // U+0045 (E)
            new byte[] { 0x7f, 0x01, 0x01, 0x01, 0x0f, 0x01, 0x01, 0x01, 0x01, 0x00, 0x00, 0x00 }, // U+0046 (F)
            new byte[] { 0x3c, 0x42, 0x01, 0x01, 0x01, 0x71, 0x41, 0x42, 0x3c, 0x00, 0x00, 0x00 }, // U+0047 (G)
            new byte[] { 0x41, 0x41, 0x41, 0x41, 0x7f, 0x41, 0x41, 0x41, 0x41, 0x00, 0x00, 0x00 }, // U+0048 (H)
            new byte[] { 0x1c, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x1c, 0x00, 0x00, 0x00 }, // U+0049 (I)
            new byte[] { 0x38, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x11, 0x0e, 0x00, 0x00, 0x00 }, // U+004A (J)
            new byte[] { 0x21, 0x11, 0x09, 0x05, 0x03, 0x05, 0x09, 0x11, 0x21, 0x00, 0x00, 0x00 }, // U+004B (K)
            new byte[] { 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x01, 0x3f, 0x00, 0x00, 0x00 }, // U+004C (L)
            new byte[] { 0x41, 0x63, 0x55, 0x49, 0x41, 0x41, 0x41, 0x41, 0x41, 0x00, 0x00, 0x00 }, // U+004D (M)
            new byte[] { 0x41, 0x41, 0x43, 0x45, 0x49, 0x51, 0x61, 0x41, 0x41, 0x00, 0x00, 0x00 }, // U+004E (N)
            new byte[] { 0x1c, 0x22, 0x41, 0x41, 0x41, 0x41, 0x41, 0x22, 0x1c, 0x00, 0x00, 0x00 }, // U+004F (O)
            new byte[] { 0x3f, 0x41, 0x41, 0x41, 0x3f, 0x01, 0x01, 0x01, 0x01, 0x00, 0x00, 0x00 }, // U+0050 (P)
            new byte[] { 0x1c, 0x22, 0x41, 0x41, 0x41, 0x41, 0x51, 0x22, 0x5c, 0x00, 0x00, 0x00 }, // U+0051 (Q)
            new byte[] { 0x3f, 0x41, 0x41, 0x41, 0x3f, 0x41, 0x41, 0x41, 0x41, 0x00, 0x00, 0x00 }, // U+0052 (R)
            new byte[] { 0x3e, 0x41, 0x01, 0x01, 0x3e, 0x40, 0x40, 0x41, 0x3e, 0x00, 0x00, 0x00 }, // U+0053 (S)
            new byte[] { 0x7f, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x00, 0x00, 0x00 }, // U+0054 (T)
            new byte[] { 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x3e, 0x00, 0x00, 0x00 }, // U+0055 (U)
            new byte[] { 0x41, 0x41, 0x41, 0x41, 0x41, 0x41, 0x22, 0x14, 0x08, 0x00, 0x00, 0x00 }, // U+0056 (V)
            new byte[] { 0x41, 0x41, 0x41, 0x41, 0x41, 0x49, 0x55, 0x63, 0x41, 0x00, 0x00, 0x00 }, // U+0057 (W)
            new byte[] { 0x41, 0x41, 0x22, 0x14, 0x08, 0x14, 0x22, 0x41, 0x41, 0x00, 0x00, 0x00 }, // U+0058 (X)
            new byte[] { 0x41, 0x41, 0x22, 0x14, 0x08, 0x08, 0x08, 0x08, 0x08, 0x00, 0x00, 0x00 }, // U+0059 (Y)
            new byte[] { 0x7f, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01, 0x7f, 0x00, 0x00, 0x00 }, // U+005A (Z)
            new byte[] { 0x3c, 0x04, 0x04, 0x04, 0x04, 0x04, 0x04, 0x04, 0x3c, 0x00, 0x00, 0x00 }, // U+005B ([)
            new byte[] { 0x00, 0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x00, 0x00, 0x00, 0x00 }, // U+005C (\)
            new byte[] { 0x1e, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x10, 0x1e, 0x00, 0x00, 0x00 }, // U+005D (])
            new byte[] { 0x08, 0x14, 0x22, 0x41, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, // U+005E (^)
            new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7f, 0x00, 0x00, 0x00 }, // U+005F (_)
            new byte[] { 0x02, 0x04, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, // U+0060 (`)
            new byte[] { 0x00, 0x00, 0x00, 0x1c, 0x22, 0x21, 0x21, 0x31, 0x2e, 0x00, 0x00, 0x00 }, // U+0061 (a)
            new byte[] { 0x01, 0x01, 0x01, 0x1d, 0x23, 0x21, 0x21, 0x23, 0x1d, 0x00, 0x00, 0x00 }, // U+0062 (b)
            new byte[] { 0x00, 0x00, 0x00, 0x1e, 0x21, 0x01, 0x01, 0x21, 0x1e, 0x00, 0x00, 0x00 }, // U+0063 (c)
            new byte[] { 0x20, 0x20, 0x20, 0x2e, 0x31, 0x21, 0x21, 0x31, 0x2e, 0x00, 0x00, 0x00 }, // U+0064 (d)
            new byte[] { 0x00, 0x00, 0x00, 0x1e, 0x21, 0x21, 0x3f, 0x01, 0x3e, 0x00, 0x00, 0x00 }, // U+0065 (e)
            new byte[] { 0x18, 0x04, 0x04, 0x04, 0x1f, 0x04, 0x04, 0x04, 0x04, 0x00, 0x00, 0x00 }, // U+0066 (f)
            new byte[] { 0x00, 0x00, 0x00, 0x2c, 0x32, 0x21, 0x21, 0x21, 0x3e, 0x20, 0x21, 0x1e }, // U+0067 (g)
            new byte[] { 0x01, 0x01, 0x01, 0x0d, 0x13, 0x21, 0x21, 0x21, 0x21, 0x00, 0x00, 0x00 }, // U+0068 (h)
            new byte[] { 0x00, 0x08, 0x00, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x00, 0x00, 0x00 }, // U+0069 (i)
            new byte[] { 0x00, 0x08, 0x00, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x09, 0x06, 0x00 }, // U+006A (j)
            new byte[] { 0x01, 0x01, 0x11, 0x09, 0x05, 0x03, 0x05, 0x09, 0x11, 0x00, 0x00, 0x00 }, // U+006B (k)
            new byte[] { 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x00, 0x00, 0x00 }, // U+006C (l)
            new byte[] { 0x00, 0x00, 0x00, 0x36, 0x49, 0x49, 0x49, 0x49, 0x49, 0x00, 0x00, 0x00 }, // U+006D (m)
            new byte[] { 0x00, 0x00, 0x00, 0x1d, 0x23, 0x21, 0x21, 0x21, 0x21, 0x00, 0x00, 0x00 }, // U+006E (n)
            new byte[] { 0x00, 0x00, 0x00, 0x1e, 0x21, 0x21, 0x21, 0x21, 0x1e, 0x00, 0x00, 0x00 }, // U+006F (o)
            new byte[] { 0x00, 0x00, 0x00, 0x1d, 0x23, 0x21, 0x21, 0x23, 0x1d, 0x01, 0x01, 0x01 }, // U+0070 (p)
            new byte[] { 0x00, 0x00, 0x00, 0x2e, 0x31, 0x21, 0x21, 0x31, 0x2e, 0x20, 0x20, 0x20 }, // U+0071 (q)
            new byte[] { 0x00, 0x00, 0x00, 0x1d, 0x23, 0x01, 0x01, 0x01, 0x01, 0x00, 0x00, 0x00 }, // U+0072 (r)
            new byte[] { 0x00, 0x00, 0x00, 0x1e, 0x21, 0x06, 0x18, 0x21, 0x1e, 0x00, 0x00, 0x00 }, // U+0073 (s)
            new byte[] { 0x00, 0x08, 0x08, 0x3e, 0x08, 0x08, 0x08, 0x08, 0x08, 0x00, 0x00, 0x00 }, // U+0074 (t)
            new byte[] { 0x00, 0x00, 0x00, 0x21, 0x21, 0x21, 0x21, 0x21, 0x1e, 0x00, 0x00, 0x00 }, // U+0075 (u)
            new byte[] { 0x00, 0x00, 0x00, 0x11, 0x11, 0x11, 0x11, 0x0a, 0x04, 0x00, 0x00, 0x00 }, // U+0076 (v)
            new byte[] { 0x00, 0x00, 0x00, 0x41, 0x41, 0x41, 0x49, 0x49, 0x36, 0x00, 0x00, 0x00 }, // U+0077 (w)
            new byte[] { 0x00, 0x00, 0x00, 0x21, 0x12, 0x0c, 0x0c, 0x12, 0x21, 0x00, 0x00, 0x00 }, // U+0078 (x)
            new byte[] { 0x00, 0x00, 0x00, 0x21, 0x21, 0x21, 0x21, 0x21, 0x3e, 0x20, 0x21, 0x1e }, // U+0079 (y)
            new byte[] { 0x00, 0x00, 0x00, 0x3f, 0x10, 0x08, 0x04, 0x02, 0x3f, 0x00, 0x00, 0x00 }, // U+007A (z)
            new byte[] { 0x18, 0x04, 0x04, 0x04, 0x02, 0x04, 0x04, 0x04, 0x18, 0x00, 0x00, 0x00 }, // U+007B ({)
            new byte[] { 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x00, 0x00 }, // U+007C (|)
            new byte[] { 0x0c, 0x10, 0x10, 0x10, 0x20, 0x10, 0x10, 0x10, 0x0c, 0x00, 0x00, 0x00 }, // U+007D (})
            new byte[] { 0x26, 0x19, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, // U+007E (~)
            new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, // U+007F
        };


        public override byte Width { get => 8; }

        /// <summary>
        /// Font height.
        /// </summary>
        public override byte Height { get => 12; }

        /// <summary>
        ///     Get the binary representation of an ASCII character from the
        ///     font table.
        /// </summary>
        /// <param name="character">Character to look up.</param>
        /// <returns>
        ///     Byte array containing the rows of pixels in the character.  Unknown byte codes will result in a space being
        ///     returned.
        /// </returns>
        public override byte[] this[char character]
        {
            get
            {
                var index = (byte)character;
                if ((index < 32) || (index > 127))
                    return _fontTable[0x20];
                else
                    return _fontTable[index - 0x20];
            }
        }

    }
}

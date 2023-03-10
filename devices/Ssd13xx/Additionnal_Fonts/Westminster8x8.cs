// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// File Generated by Bitmap2Font

using System;

namespace Iot.Device.Ssd13xx.Samples
{
    public class Westminster8x8 : IFont
    {
        private static readonly byte[][] _fontTable =
        {
        new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
        new byte[] { 0x08, 0x08, 0x18, 0x18, 0x18, 0x00, 0x18, 0x00},
        new byte[] { 0x36, 0x24, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
        new byte[] { 0x36, 0x36, 0x7F, 0x36, 0x7F, 0x36, 0x36, 0x00},
        new byte[] { 0x18, 0x7E, 0x02, 0x7E, 0x60, 0x7E, 0x18, 0x00},
        new byte[] { 0x00, 0x26, 0x10, 0x08, 0x04, 0x60, 0x00, 0x00},
        new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
        new byte[] { 0x18, 0x10, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
        new byte[] { 0x18, 0x04, 0x04, 0x04, 0x04, 0x04, 0x18, 0x00},
        new byte[] { 0x18, 0x20, 0x20, 0x20, 0x20, 0x20, 0x18, 0x00},
        new byte[] { 0x00, 0x2A, 0x1C, 0x3E, 0x1C, 0x2A, 0x00, 0x00},
        new byte[] { 0x00, 0x10, 0x10, 0x7C, 0x10, 0x10, 0x00, 0x00},
        new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x18, 0x10},
        new byte[] { 0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x00},
        new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x18, 0x00},
        new byte[] { 0x20, 0x10, 0x08, 0x04, 0x02, 0x01, 0x00, 0x00},
        new byte[] { 0x7E, 0x42, 0x42, 0x62, 0x62, 0x62, 0x7E, 0x00},
        new byte[] { 0x10, 0x10, 0x10, 0x18, 0x18, 0x18, 0x18, 0x00},
        new byte[] { 0x7E, 0x42, 0x40, 0x7E, 0x06, 0x06, 0x7E, 0x00},
        new byte[] { 0x3E, 0x20, 0x20, 0x7C, 0x60, 0x60, 0x7E, 0x00},
        new byte[] { 0x38, 0x2C, 0x26, 0xFE, 0x30, 0x30, 0x30, 0x00},
        new byte[] { 0x7E, 0x02, 0x02, 0x7E, 0x60, 0x62, 0x7E, 0x00},
        new byte[] { 0x7E, 0x02, 0x02, 0x7E, 0x62, 0x62, 0x7E, 0x00},
        new byte[] { 0x7E, 0x40, 0x40, 0x60, 0x60, 0x60, 0x60, 0x00},
        new byte[] { 0x3C, 0x24, 0x24, 0x7E, 0x62, 0x62, 0x7E, 0x00},
        new byte[] { 0x7E, 0x42, 0x42, 0x7E, 0x60, 0x60, 0x60, 0x00},
        new byte[] { 0x00, 0x18, 0x00, 0x00, 0x18, 0x00, 0x00, 0x00},
        new byte[] { 0x00, 0x18, 0x00, 0x00, 0x18, 0x10, 0x00, 0x00},
        new byte[] { 0x10, 0x08, 0x04, 0x02, 0x04, 0x08, 0x10, 0x00},
        new byte[] { 0x00, 0x00, 0x3C, 0x00, 0x3C, 0x00, 0x00, 0x00},
        new byte[] { 0x08, 0x10, 0x20, 0x40, 0x20, 0x10, 0x08, 0x00},
        new byte[] { 0x7E, 0x40, 0x40, 0x7E, 0x06, 0x00, 0x06, 0x00},
        new byte[] { 0x7E, 0x7A, 0x6A, 0x6A, 0x7A, 0x02, 0x7E, 0x00},
        new byte[] { 0x3C, 0x24, 0x24, 0x7E, 0x46, 0x46, 0x46, 0x00},
        new byte[] { 0x3C, 0x24, 0x24, 0x7E, 0x46, 0x46, 0x7E, 0x00},
        new byte[] { 0x7E, 0x42, 0x02, 0x06, 0x06, 0x46, 0x7E, 0x00},
        new byte[] { 0x3E, 0x42, 0x42, 0x46, 0x46, 0x46, 0x3E, 0x00},
        new byte[] { 0x7E, 0x02, 0x02, 0x7E, 0x06, 0x06, 0x7E, 0x00},
        new byte[] { 0x7E, 0x02, 0x02, 0x7E, 0x06, 0x06, 0x06, 0x00},
        new byte[] { 0x7E, 0x42, 0x02, 0x66, 0x46, 0x46, 0x7E, 0x00},
        new byte[] { 0x42, 0x42, 0x42, 0x7E, 0x46, 0x46, 0x46, 0x00},
        new byte[] { 0x08, 0x08, 0x08, 0x18, 0x18, 0x18, 0x18, 0x00},
        new byte[] { 0x20, 0x20, 0x20, 0x60, 0x60, 0x62, 0x7E, 0x00},
        new byte[] { 0x02, 0x22, 0x22, 0x7E, 0x46, 0x46, 0x46, 0x00},
        new byte[] { 0x02, 0x02, 0x02, 0x06, 0x06, 0x06, 0x7E, 0x00},
        new byte[] { 0x7F, 0x49, 0x49, 0x4B, 0x4B, 0x4B, 0x4B, 0x00},
        new byte[] { 0x7E, 0x42, 0x42, 0x46, 0x46, 0x46, 0x46, 0x00},
        new byte[] { 0x7E, 0x62, 0x42, 0x42, 0x42, 0x42, 0x7E, 0x00},
        new byte[] { 0x7E, 0x42, 0x42, 0x7E, 0x06, 0x06, 0x06, 0x00},
        new byte[] { 0x7E, 0x42, 0x42, 0x42, 0x42, 0x72, 0x7E, 0x00},
        new byte[] { 0x3E, 0x22, 0x22, 0x7E, 0x46, 0x46, 0x46, 0x00},
        new byte[] { 0x7E, 0x42, 0x02, 0x7E, 0x60, 0x62, 0x7E, 0x00},
        new byte[] { 0x7F, 0x08, 0x08, 0x18, 0x18, 0x18, 0x18, 0x00},
        new byte[] { 0x42, 0x42, 0x42, 0x46, 0x46, 0x46, 0x7E, 0x00},
        new byte[] { 0x46, 0x46, 0x46, 0x44, 0x24, 0x24, 0x3C, 0x00},
        new byte[] { 0x49, 0x49, 0x49, 0x4B, 0x4B, 0x4B, 0x7F, 0x00},
        new byte[] { 0x42, 0x42, 0x42, 0x3C, 0x46, 0x46, 0x46, 0x00},
        new byte[] { 0x42, 0x42, 0x42, 0x7E, 0x18, 0x18, 0x18, 0x00},
        new byte[] { 0x7E, 0x40, 0x40, 0x7E, 0x06, 0x46, 0x7E, 0x00},
        new byte[] { 0x38, 0x08, 0x08, 0x0C, 0x0C, 0x0C, 0x3C, 0x00},
        new byte[] { 0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x00, 0x00},
        new byte[] { 0x1C, 0x10, 0x10, 0x30, 0x30, 0x30, 0x3C, 0x00},
        new byte[] { 0x08, 0x14, 0x22, 0x00, 0x00, 0x00, 0x00, 0x00},
        new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7E, 0x00},
        new byte[] { 0x18, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
        new byte[] { 0x00, 0x00, 0x7E, 0x40, 0x7E, 0x46, 0x7E, 0x00},
        new byte[] { 0x02, 0x02, 0x7E, 0x42, 0x46, 0x46, 0x7E, 0x00},
        new byte[] { 0x00, 0x00, 0x7E, 0x42, 0x06, 0x46, 0x7E, 0x00},
        new byte[] { 0x40, 0x40, 0x7E, 0x42, 0x46, 0x46, 0x7E, 0x00},
        new byte[] { 0x00, 0x00, 0x7E, 0x42, 0x7E, 0x06, 0x7E, 0x00},
        new byte[] { 0x78, 0x08, 0x3E, 0x08, 0x18, 0x18, 0x18, 0x00},
        new byte[] { 0x00, 0x00, 0x7E, 0x42, 0x42, 0x7E, 0x40, 0x7E},
        new byte[] { 0x02, 0x02, 0x7E, 0x42, 0x46, 0x46, 0x46, 0x00},
        new byte[] { 0x00, 0x18, 0x00, 0x08, 0x18, 0x18, 0x18, 0x00},
        new byte[] { 0x00, 0x18, 0x00, 0x08, 0x18, 0x18, 0x10, 0x1C},
        new byte[] { 0x02, 0x02, 0x22, 0x7E, 0x46, 0x46, 0x46, 0x00},
        new byte[] { 0x08, 0x08, 0x08, 0x08, 0x18, 0x18, 0x18, 0x00},
        new byte[] { 0x00, 0x00, 0x7F, 0x49, 0x5B, 0x5B, 0x5B, 0x00},
        new byte[] { 0x00, 0x00, 0x7E, 0x42, 0x46, 0x46, 0x46, 0x00},
        new byte[] { 0x00, 0x00, 0x7E, 0x42, 0x46, 0x46, 0x7E, 0x00},
        new byte[] { 0x00, 0x00, 0x7E, 0x42, 0x46, 0x46, 0x7E, 0x02},
        new byte[] { 0x00, 0x00, 0x7E, 0x42, 0x46, 0x46, 0x7E, 0x40},
        new byte[] { 0x00, 0x00, 0x7E, 0x42, 0x06, 0x06, 0x06, 0x00},
        new byte[] { 0x00, 0x00, 0x7E, 0x02, 0x7E, 0x60, 0x7E, 0x00},
        new byte[] { 0x08, 0x08, 0x3E, 0x08, 0x18, 0x18, 0x18, 0x00},
        new byte[] { 0x00, 0x00, 0x42, 0x42, 0x46, 0x46, 0x7E, 0x00},
        new byte[] { 0x00, 0x00, 0x46, 0x46, 0x46, 0x64, 0x3C, 0x00},
        new byte[] { 0x00, 0x00, 0x49, 0x49, 0x5B, 0x5B, 0x7F, 0x00},
        new byte[] { 0x00, 0x00, 0x42, 0x42, 0x3C, 0x46, 0x46, 0x00},
        new byte[] { 0x00, 0x00, 0x46, 0x46, 0x46, 0x7E, 0x40, 0x7E},
        new byte[] { 0x00, 0x00, 0x7E, 0x40, 0x7E, 0x06, 0x7E, 0x00},
        new byte[] { 0x38, 0x0C, 0x0C, 0x07, 0x0C, 0x0C, 0x38, 0x00},
        new byte[] { 0x18, 0x18, 0x18, 0x00, 0x18, 0x18, 0x18, 0x00},
        new byte[] { 0x07, 0x0C, 0x0C, 0x38, 0x0C, 0x0C, 0x07, 0x00},
        new byte[] { 0x6E, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00},
        new byte[] { 0x00, 0x08, 0x1C, 0x36, 0x63, 0x63, 0x7F, 0x00},
        };

        public override byte Width { get => 8; }
        public override byte Height { get =>8; }

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

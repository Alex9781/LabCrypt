﻿using GOST.Interfaces;

namespace GOST.SBlocks
{
    internal class CryptoProDBlock : ISBlocks
    {
        public byte[][] SBlockTable { get; } =
        {
            new byte[] { 0xF,  0xC,  0x2,  0xA,  0x6,  0x4,  0x5,  0x0,  0x7,  0x9,  0xE,  0xD,  0x1,  0xB,  0x8,  0x3},
            new byte[] { 0xB,  0x6,  0x3,  0x4,  0xC,  0xF,  0xE,  0x2,  0x7,  0xD,  0x8,  0x0,  0x5,  0xA,  0x9,  0x1},
            new byte[] { 0x1,  0xC,  0xB,  0x0,  0xF,  0xE,  0x6,  0x5,  0xA,  0xD,  0x4,  0x8,  0x9,  0x3,  0x7,  0x2},
            new byte[] { 0x1,  0x5,  0xE,  0xC,  0xA,  0x7,  0x0,  0xD,  0x6,  0x2,  0xB,  0x4,  0x9,  0x3,  0xF,  0x8},
            new byte[] { 0x0,  0xC,  0x8,  0x9,  0xD,  0x2,  0xA,  0xB,  0x7,  0x3,  0x6,  0x5,  0x4,  0xE,  0xF,  0x1},
            new byte[] { 0x8,  0x0,  0xF,  0x3,  0x2,  0x5,  0xE,  0xB,  0x1,  0xA,  0x4,  0x7,  0xC,  0x9,  0xD,  0x6},
            new byte[] { 0x3,  0x0,  0x6,  0xF,  0x1,  0xE,  0x9,  0x2,  0xD,  0x8,  0xC,  0x4,  0xB,  0xA,  0x5,  0x7},
            new byte[] { 0x1,  0xA,  0x6,  0x8,  0xF,  0xB,  0x0,  0x4,  0xC,  0x3,  0x5,  0x9,  0x7,  0xD,  0x2,  0xE}
        };
    }
}

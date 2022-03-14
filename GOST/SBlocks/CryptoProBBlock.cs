﻿using GOST.Interfaces;

namespace GOST.SBlocks
{
    internal class CryptoProBBlock : ISBlocks
    {
        public byte[][] SBlockTable { get; } =
        {
            new byte[] { 0x8,  0x4,  0xB,  0x1,  0x3,  0x5,  0x0,  0x9,  0x2,  0xE,  0xA,  0xC,  0xD,  0x6,  0x7,  0xF},
            new byte[] { 0x0,  0x1,  0x2,  0xA,  0x4,  0xD,  0x5,  0xC,  0x9,  0x7,  0x3,  0xF,  0xB,  0x8,  0x6,  0xE},
            new byte[] { 0xE,  0xC,  0x0,  0xA,  0x9,  0x2,  0xD,  0xB,  0x7,  0x5,  0x8,  0xF,  0x3,  0x6,  0x1,  0x4},
            new byte[] { 0x7,  0x5,  0x0,  0xD,  0xB,  0x6,  0x1,  0x2,  0x3,  0xA,  0xC,  0xF,  0x4,  0xE,  0x9,  0x8},
            new byte[] { 0x2,  0x7,  0xC,  0xF,  0x9,  0x5,  0xA,  0xB,  0x1,  0x4,  0x0,  0xD,  0x6,  0x8,  0xE,  0x3},
            new byte[] { 0x8,  0x3,  0x2,  0x6,  0x4,  0xD,  0xE,  0xB,  0xC,  0x1,  0x7,  0xF,  0xA,  0x0,  0x9,  0x5},
            new byte[] { 0x5,  0x2,  0xA,  0xB,  0x9,  0x1,  0xC,  0x3,  0x7,  0x4,  0xD,  0x0,  0x6,  0xF,  0x8,  0xE},
            new byte[] { 0x0,  0x4,  0xB,  0xE,  0x8,  0x3,  0x7,  0x1,  0xA,  0x2,  0x9,  0x6,  0xF,  0xD,  0x5,  0xC}
        };
    }
}

using System;

namespace ColorPicker
{
    [Flags]
    public enum Colors
    {
        Black = 0x1,
        Blue = 0x1 << 1,
        Cyan = 0x1 << 2,
        Grey = 0x1 << 3,
        Green = 0x1 << 4,
        Magenta = 0x1 << 5,
        Red = 0x1 << 6,
        White = 0x1 << 7,
        Yellow = 0x1 << 8
    }
}
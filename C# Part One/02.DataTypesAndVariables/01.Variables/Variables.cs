// Declare five variables choosing for each of them the most appropriate of the types:
// byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
// 52130, -115, 4825932, 97, -10000.

using System;

class Variables
{
    static void Main()
    {
        ushort unsignedShort = 52130;
        sbyte signedByte = -115;
        int @int = 4825932;
        byte @byte = 97;
        short @short = -10000;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", unsignedShort, signedByte, @int, @byte, @short);
    }
}

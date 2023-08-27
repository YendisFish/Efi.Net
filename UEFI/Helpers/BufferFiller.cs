using System;

namespace EfiNet.UEFI.Helpers;

public unsafe struct BufferFiller
{
    public static void FillChar(Character *ptr, int size)
    {
        for(int i = 0; i < size; i++)
        {
            ptr[i] = Character.Empty;
        }
    }
}
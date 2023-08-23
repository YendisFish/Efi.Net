namespace System;

public unsafe struct UShrt
{
    private fixed byte dat[2];

    private UShrt(ushort x)
    {
        byte *ptr = (byte *)&x;
        for(int i = 0; i < 2; i++)
        {
            dat[i] = ptr[i];
        }
    }

    public static implicit operator UShrt(ushort x)
    {
        return new UShrt(x);
    }

    public static implicit operator ushort(UShrt x)
    {
        return *(ushort *)x.dat;
    }
}
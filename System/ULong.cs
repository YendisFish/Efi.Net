namespace System;

public unsafe struct ULong
{
    private fixed byte dat[8];

    private ULong(ulong x)
    {
        byte *ptr = (byte *)&x;
        for(int i = 0; i < 8; i++)
        {
            dat[i] = ptr[i];
        }
    }

    public static implicit operator ULong(ulong x)
    {
        return new ULong(x);
    }

    public static implicit operator ulong(ULong x)
    {
        return *(ulong *)x.dat;
    }
}
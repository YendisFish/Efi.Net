namespace System;

public unsafe struct UInteger
{
    private fixed byte dat[4];

    private UInteger(uint x)
    {
        byte *ptr = (byte *)&x;
        for(int i = 0; i < 4; i++)
        {
            dat[i] = ptr[i];
        }
    }

    public static implicit operator UInteger(uint x)
    {
        return new UInteger(x);
    }

    public static implicit operator uint(UInteger x)
    {
        return *(uint *)x.dat;
    }
}
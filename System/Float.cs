namespace System;

public unsafe struct Flt
{
    private fixed byte dat[4];

    private Flt(float x)
    {
        byte *ptr = (byte *)&x;
        for(int i = 0; i < 4; i++)
        {
            dat[i] = ptr[i];
        }
    }

    public static implicit operator Flt(float x)
    {
        return new Flt(x);
    }

    public static implicit operator float(Flt x)
    {
        return *(float *)x.dat;
    }
}
namespace System;

public unsafe struct Dbl
{
    private fixed byte dat[8];

    private Dbl(double x)
    {
        byte *ptr = (byte *)&x;
        for(int i = 0; i < 8; i++)
        {
            dat[i] = ptr[i];
        }
    }

    public static implicit operator Dbl(double x)
    {
        return new Dbl(x);
    }

    public static implicit operator double(Dbl x)
    {
        return *(double *)x.dat;
    }
}
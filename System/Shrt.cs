namespace System;

public unsafe struct Shrt
{
    private fixed byte dat[2];

    private Shrt(short x)
    {
        byte *ptr = (byte *)&x;
        for(int i = 0; i < 2; i++)
        {
            dat[i] = ptr[i];
        }
    }

    public static implicit operator Shrt(short x)
    {
        return new Shrt(x);
    }

    public static implicit operator short(Shrt x)
    {
        return *(short *)x.dat;
    }
}
namespace System;

public unsafe struct Long
{
    private fixed byte dat[8];

    private Long(long x)
    {
        byte *ptr = (byte *)&x;
        for(int i = 0; i < 8; i++)
        {
            dat[i] = ptr[i];
        }
    }

    public static implicit operator Long(long x)
    {
        return new Long(x);
    }

    public static implicit operator long(Long x)
    {
        return *(long *)x.dat;
    }
}
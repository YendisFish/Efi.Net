namespace System;

public unsafe struct Integer
{
    private fixed byte dat[4];

    private Integer(int x)
    {
        byte *ptr = (byte *)&x;
        for(int i = 0; i < 4; i++)
        {
            dat[i] = ptr[i];
        }
    }

    public static implicit operator Integer(int x)
    {
        return new Integer(x);
    }

    public static implicit operator int(Integer x)
    {
        return *(int *)x.dat;
    }
}
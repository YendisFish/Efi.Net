namespace System;

public unsafe struct Bte
{
    private fixed byte dat[1];

    private Bte(byte x)
    {
        byte *ptr = &x;
        dat[0] = *ptr;
    }

    public static implicit operator Bte(byte x)
    {
        return new Bte(x);
    }

    public static implicit operator byte(Bte x)
    {
        return *x.dat;
    }
}
namespace System;

public unsafe struct UByte
{
    private fixed byte dat[1];

    private UByte(byte x)
    {
        byte *ptr = &x;
        dat[0] = *ptr;
    }

    public static implicit operator UByte(byte x)
    {
        return new UByte(x);
    }

    public static implicit operator byte(UByte x)
    {
        return *x.dat;
    }
}
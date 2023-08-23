namespace System;

public unsafe struct Character
{
    private fixed byte dat[1];

    private Character(char x)
    {
        byte *ptr = (byte *)&x;
        dat[0] = *ptr;
    }

    public static implicit operator Character(char x)
    {
        return new Character(x);
    }

    public static implicit operator char(Character x)
    {
        return *(char *)x.dat;
    }
}
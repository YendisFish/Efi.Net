namespace System;

public unsafe struct Str
{
    private Character *ptr;
    public int length;

    private Str(Character *cptr, int len)
    {
        for(int i = 0; i < len; i++)
        {
            ptr[i] = cptr[i];
        }

        this.length = len;
    }

    public Character * ToCharPtr() => ptr;

    public static Str FromCharPtr(char *ptr, int len)
    {
        Str st = new Str((Character *)ptr, len);
        return st;
    }

    public static Str FromManaged(string str, int length)
    {
        char *dat;
        fixed(char *ptr = str) { dat = ptr; }

        return new Str((Character *)dat, length);
    }
}
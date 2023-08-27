namespace System;


public unsafe struct Str
{
    private Character *ptr;
    public int length;

    public Character this[int index]
    {
        get
        {
            return ptr[index];
        }
        
        set 
        {
            ptr[index] = value;
        }
    } 

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

    public static implicit operator Str(string s)
    {
        char *p;
        fixed(char *ptr = s)
        {
            p = ptr;
        }

        return new Str((Character *)p, s.Length);
    }
}

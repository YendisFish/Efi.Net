using System.Runtime.InteropServices;
using EfiNet.UEFI;
using EfiNet.UEFI.Wrappers;

namespace System;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Console
{
    private EfiProvider provider;

    public UInteger x = 0;
    public UInteger y = 0;

    public Console(EfiProvider prov)
    {
        provider = prov;
    }

    public static void BuildAndAttach(EfiProvider con, Console *ptr)
    {
        Console c = new(con);
        *ptr = c;
    }

    public unsafe void WriteLine(Str st)
    {
        provider.OutputStr(st);
        
        y = (uint)y + 1;
        provider.tableRef->consoleOut->SetCursorPosition(provider.tableRef->consoleOut, 0, y);
        
        provider.OutputStr("\n");
    }
}
using System.Runtime.InteropServices;
using EfiNet.UEFI;

namespace EfiNet.UEFI.Wrappers;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct EfiProvider
{
    public EfiSystemTable *tableRef;

    public EfiProvider(EfiSystemTable *tr)
    {
        tableRef = tr;
    }

    public void OutputStr(Str str)
    {
        tableRef->consoleOut->OutputString(tableRef->consoleOut, str.ToCharPtr());
    }

    public void ReadStr(Str *ptr, int buf)
    {
        for(int i = 0; i < buf; i++)
        {
            EfiInputKey *k = tableRef->consoleIn->ReadKeyStroke(tableRef->consoleIn);

            if((*k).unicodeChar == '\n')
            {
                break;
            }

            (*ptr)[i] = (*k).unicodeChar;
        }
    }
}
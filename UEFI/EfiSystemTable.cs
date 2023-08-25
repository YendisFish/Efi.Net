using System;
using System.Runtime.InteropServices;

namespace EfiNet.UEFI;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct EfiSystemTable
{
    public EfiTableHeader header;
    public Character *firmwareVendor;
    public UInteger firwareRevision;
    public EfiHandle consoleInHandle;
    public EfiSimpleTextInput *consoleIn;
    public EfiHandle consoleOutHandle;
    public EfiSimpleTextOutput *consoleOut;
    public EfiHandle stderrHandle;
    public void *stdErr;
    public void *runtimeServices;
    public void *bootServices;
    public ULong numberOfTableEntries;
    public void *configurationTable;
}
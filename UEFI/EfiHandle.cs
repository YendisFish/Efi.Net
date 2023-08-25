using System.Runtime.InteropServices;

namespace EfiNet.UEFI;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct EfiHandle
{
    private void *handle;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct EfiEvent
{
    private void *eventHandle;
}
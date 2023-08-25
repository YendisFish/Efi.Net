using System;
using System.Runtime.InteropServices;

namespace EfiNet.UEFI;

[StructLayout(LayoutKind.Sequential)]
public struct EfiTableHeader
{
    public ULong signature;
    public UInteger revision;
    public UInteger headerSize;
    public UInteger CRC32;
    public UInteger reserved;
}
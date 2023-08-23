using System;

namespace EfiNet.UEFI;

public struct EfiTableHeader
{
    public ULong signature;
    public UInteger revision;
    public UInteger headerSize;
    public UInteger CRC32;
    public UInteger reserved;
}
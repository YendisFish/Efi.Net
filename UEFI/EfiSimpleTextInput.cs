using System;
using System.Runtime.InteropServices;

namespace EfiNet.UEFI;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct EfiSimpleTextInput
{
    public delegate* unmanaged<EfiSimpleTextInput *, bool> Reset;
    public delegate* unmanaged<EfiSimpleTextInput *, EfiInputKey *> ReadKeyStroke;
}

[StructLayout(LayoutKind.Sequential)]
public struct EfiInputKey
{
    public UShrt scanCode;
    public Character unicodeChar;
}
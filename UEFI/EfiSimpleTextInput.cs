using System;

namespace EfiNet.UEFI;

public unsafe struct EfiSimpleTextInput
{
    public delegate* unmanaged<EfiSimpleTextInput *, bool> Reset;
    public delegate* unmanaged<EfiSimpleTextInput *, EfiInputKey *> ReadKeyStroke;
}

public struct EfiInputKey
{
    public UShrt scanCode;
    public Character unicodeChar;
}
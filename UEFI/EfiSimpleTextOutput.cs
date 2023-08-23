using System;

namespace EfiNet.UEFI;

public unsafe struct EfiSimpleTextOutput
{
    public delegate* unmanaged<EfiSimpleTextOutput*, EfiStatus> Reset;
    public delegate* unmanaged<EfiSimpleTextOutput *, Character *, EfiStatus> OutputString;
    public delegate* unmanaged<EfiSimpleTextOutput *, EfiInputKey *, EfiStatus> QueryKey;
    public EfiSimpleTxtInputMode *mode;
}

public struct EfiSimpleTxtInputMode
{
    public Integer maxMode;
    public Integer mode;
    public Integer attribute;
    public Integer cursorColumn;
    public Integer cursorRow;
    public bool cursorVisible;
}
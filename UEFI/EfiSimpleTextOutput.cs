using System;
using System.Runtime.InteropServices;

namespace EfiNet.UEFI;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct EfiSimpleTextOutput
{
    public delegate* unmanaged<EfiSimpleTextOutput*, EfiStatus> Reset;
    public delegate* unmanaged<EfiSimpleTextOutput *, Character *, EfiStatus> OutputString;
    public delegate* unmanaged<EfiSimpleTextOutput *, EfiInputKey *, EfiStatus> QueryKey;
    public EfiSimpleTxtInputMode *mode;
}

[StructLayout(LayoutKind.Sequential)]
public struct EfiSimpleTxtInputMode
{
    public Integer maxMode;
    public Integer mode;
    public Integer attribute;
    public Integer cursorColumn;
    public Integer cursorRow;
    public bool cursorVisible;
}
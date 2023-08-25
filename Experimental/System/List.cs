using System;
using System.Runtime.InteropServices;
using EfiNet.Experimental.Interop;

namespace System.Experimental;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct List<T> where T: unmanaged
{
    private KernelCallHost hostFuncs;

    private T *ptr;
    public int Length;

    public T this[int index]
    {
        get
        {
            if(index >= Length) { return this.ptr[Length - 1]; }

            return ptr[index];
        }

        set 
        {
            if(index >= Length) { return; }
            ptr[index] = value;
        }
    }

    public List(KernelCallHost _hostFuncs)
    {
        this.hostFuncs = _hostFuncs;

        ptr = this.hostFuncs.Alloc<T>(sizeof(T));
        Length = 0;
    }

    public void Add(T val)
    {
        this.ptr = this.hostFuncs.Alloc<T>(sizeof(T) * (Length + 1));
        this.Length = this.Length + 1;

        this.ptr[Length - 1] = val;
    }

    public void Add(T *val)
    {
        this.hostFuncs.Free(this.ptr);

        this.ptr = this.hostFuncs.Alloc<T>(sizeof(T) * (Length + 1));
        this.Length = this.Length + 1;

        this.ptr[Length - 1] = *val;
    }
}
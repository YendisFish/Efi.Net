using System;
using System.Runtime.InteropServices;

namespace EfiNet.Experimental.Interop;


/*
    This is essentially a form
    of dependency injection in
    my library.

    It allows you to inject
    external kernel functions
    into the library so it can
    use them in its stdlibs.

    Reason for this is allocating
    heap memory is a kernel thing
    and rewriting some libraries
    requires some sort of heap
    memory.
*/
[StructLayout(LayoutKind.Sequential)]
public unsafe struct KernelCallHost
{
    #region Unsafe Kernel Delegates
    private delegate*<int, byte *> kalloc;
    private delegate*<void *, void> kfree;
    #endregion

    public KernelCallHost(delegate*<int, byte *> kalloc)
    {
        this.kalloc = kalloc;
    }

    public T * Alloc<T>(int size) where T: unmanaged
    {
        T *ret = (T *)kalloc(size);
        return ret;
    }

    public void Free<T>(T *ptr) where T: unmanaged
    {
        kfree((void *)ptr);
    }
}
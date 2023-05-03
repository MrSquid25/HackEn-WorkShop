using System;
using System.Runtime.InteropServices;

namespace libreria
{
    internal class Win32
    {
        [DllImport("kernel32.dll")] //Cargamos mediante P/Invoke VirtualAllow y la calling convention para un puntero no delegtado de Kernel32.dll
        public static extern IntPtr VirtualAlloc(IntPtr address, uint dwSize, uint allocType, uint mode);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void WindowRun();
    }
}

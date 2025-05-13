using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MCR.NET.Hilos
{
    internal class Program
    {

        static void Main(string[] args)
        {

            bool stopped = false;
            Thread thread = new Thread(new ThreadStart(() => {
                while (!stopped)
                {
                    Console.WriteLine("Corriendo..." + stopped);
                    Thread.Sleep(1000);
                }
            }));

            thread.Start();
            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadKey();
            stopped = true;
            thread.Join();
        }
    }
}

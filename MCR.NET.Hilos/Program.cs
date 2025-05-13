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
        static bool stopped = false;

        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(EjecutaMetodoDesdeHilo));

            thread.Start();
            Console.WriteLine("Presione ENTER para salir.");

            ConsoleKeyInfo info = Console.ReadKey(true);
            if (info.Key == ConsoleKey.Enter) 
            {
                Console.WriteLine("stopped pasará a true.");
                stopped = true;
            }
            
            thread.Join();
        }

        static void EjecutaMetodoDesdeHilo()
        {
            while (!stopped)
            {
                Console.WriteLine("Corriendo..." + stopped);
                Thread.Sleep(1000);
            }
        }
    }
}

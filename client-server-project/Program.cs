using System;
using System.Threading;

namespace client_server_project
{
    class Program
    {
        static void Main()
        {
            Thread myThread = new Thread(newThread);
            myThread.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread 1: " + i);
                Thread.Sleep(500);
            }
            myThread.Join();
            Console.WriteLine("Terminou viu meu fi");
            Console.ReadLine();
        }
        static void newThread()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread 2: " + i);
                Thread.Sleep(500);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _1_Creating_thread_with_Thread_class
{
    class Program
    {
        public static void ThreadMethord()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Meth : "+ i);
               
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethord));
            t.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main Mth : "+ i);
                Thread.Sleep(0);
            }

            t.Join(); // waite for the above thread to complete 
            Console.ReadLine();
        }
    }
}

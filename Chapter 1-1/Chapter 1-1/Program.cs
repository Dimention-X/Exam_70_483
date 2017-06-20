using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_1_1
{
    class Program
    {
        public static void threadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("thread Methord calling : {0}", i);
                Thread.Sleep(0);   // it will be paued for 1000 miliseconds after print proint 0 then goes to main methord for execution 
                // and when that thread sleep then this thread will work this is synchronisation. two threads never be executed on the same portion of the program at a time.
            }
        }


        static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(threadMethod));  // ParameterizedThreadStart delegate which takes the parameter.
            t.Start(15);
            t.Join();
            


        }
    } 
}

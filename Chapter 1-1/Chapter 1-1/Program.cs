using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_1_1
{
    public static class Program
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() => { return Thread.CurrentThread.ManagedThreadId; });


        static void Main(string[] args)
        {
           
        new Thread(() =>
          {
              for (int i = 0; i <_field.Value; i++)
              {
                  Console.WriteLine("thread A: {0}",i);
              }
          }
            ).Start();

           
            new Thread(() =>
            {
                for (int i = 0; i <  _field.Value; i++)
                {
                    Console.WriteLine("thread B: {0}",i);
                    Console.WriteLine( " thread Current Culture prop : " +Thread.CurrentThread.CurrentCulture);
                   // Console.WriteLine("");
                }
            }).Start();

            Console.ReadLine();
        }
    } 
}

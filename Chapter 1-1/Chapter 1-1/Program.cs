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
       

        [ThreadStatic]         // this attribute makes the viarable used by both the threads as a static value. , 
        public static int _field;  

        static void Main(string[] args)
        {
            new Thread(
                () =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        _field++;
                        Console.WriteLine("thread A : {0}", _field);


                    }
                }
                ).Start();

            new Thread(
                () =>
                {
                    for (int i = 0; i < 10; i++)                 
                    {
                        _field++;
                        Console.WriteLine("thread B : {0}", _field);

                    }
                }).Start();


        }
    } 
}

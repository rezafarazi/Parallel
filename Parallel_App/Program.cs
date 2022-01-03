using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_App
{
    class Program
    {

        //Global variables
        static int i = 1;

        static void Main(string[] args)
        {

            Parallel.For(0, 2, get_work); 

            Parallel.For(0, 2, delegate(int a) {
                i = i * 10;
            });

            Parallel.For(0, 2, a => {
                i = i * 10;
            });

            Console.WriteLine(i);
            Console.ReadKey();

        }

        //Get a function
        public static void get_work(int a)
        {
            i = i * 10;
        }

    }
}

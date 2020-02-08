using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boxingandunboxing_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing and unboxing

            object obj = 100;//object is a reference type

            int a = 100;

            obj = a;

            int b = (int)a;

            Console.WriteLine("values of a and b = {0} and {1}", a, b);

            //passing arguments by value type

            int i, j;
            i = 10; j = 20;

            Console.WriteLine("values of i and j before function call = {0},{1}", i, j);
            ShowData1(i, j);

            Console.WriteLine("values of i and j after function call = {0},{1}", i, j);

            //passing arguments by reference
            int k, l;
            k = 10; l = 20;
            Console.WriteLine("values of k and l before function call = {0},{1}", k, l);
            ShowData2(ref k, ref l);
            Console.WriteLine("values of k and l after function call = {0},{1}", k, l);


            Console.ReadLine();
        }
        public static void ShowData1(int a, int b)
        {
            double sum = a + b;
            Console.WriteLine("sum = {0}", sum);
            a += 5;
            b += 5;
        }
        public static void ShowData2(ref int a, ref int b)
        {
            double sum = a + b;
            Console.WriteLine("sum = {0}", sum);
            a += 5;
            b += 5;
        }

    }

}


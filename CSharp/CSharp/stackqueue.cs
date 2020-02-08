using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<float> fnumbers = new Stack<float>();
            fnumbers.Push(10.90f);
            fnumbers.Push(12.90f);
            fnumbers.Push(13.90f);
            fnumbers.Push(15.90f);

            Console.WriteLine("\nBefore calling the pop method\n");

            foreach (var fn in fnumbers)
                Console.WriteLine(fn);

            fnumbers.Pop();
            Console.WriteLine("\nAfter calling the pop method\n");
            foreach (var fn in fnumbers)
                Console.WriteLine(fn);

            Queue<double> qnumbers = new Queue<double>();
            qnumbers.Enqueue(10.98);
            qnumbers.Enqueue(13.85);
            qnumbers.Enqueue(12.65);
            qnumbers.Enqueue(15.98);

            Console.WriteLine("\nBefore calling the Dequeue method\n");

            foreach (var qn in qnumbers)
                Console.WriteLine(qn);

            qnumbers.Dequeue();

            Console.WriteLine("\nAfter calling the Dequeue method\n");
            foreach (var qn in qnumbers)
                Console.WriteLine(qn);
            int a, b;
            a = 50;b = 30;

            Console.WriteLine("Before swap: a = {0}, b = {1}", a, b);

            swap<int>(ref a, ref b);

            Console.WriteLine("After swap: a = {0}, b = {1}", a, b);

            string s1, s2;
            s1 = "hello";
            s2 = "world";

            Console.WriteLine("Before swap: s1 = {0}, s2 = {1}", s1, s2);
            swap<string>(ref s1, ref s2);

            Console.WriteLine("After swap: s1 = {0},s2 = {1}", s1, s2);

            Console.ReadKey();




        }
        public static void swap<T>(ref T a,ref T b)
        {
            T c;
            c = a;
            a = b;
            b = c;
        }
    }
}

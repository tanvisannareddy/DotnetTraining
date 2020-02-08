using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_demo.program
{
    class Program
    {
            enum Department
        {
            Physics = 10,
            Chemistry = 12,
            Mathematics = 15,
            Biology = 18
        };
        enum Color
        {
            Red = 10,
            Green,
            Blue = 15
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Department ID of Physics: {0}", (int)Department.Physics);

            Console.WriteLine("Department ID of Chemistry: {0}", (int)Department.Chemistry);

            Console.WriteLine("Department ID of Mathematics: {0}", (int)Department.Mathematics);

            Console.WriteLine("Department ID of Biology: {0}", (int)Department.Biology);

            Console.WriteLine("The color Red indicates: {0}", (int)Color.Red);

            Console.WriteLine("The color Green indicates: {0}", (int)Color.Green);

            Console.WriteLine("The color Blue indicates:{0}", (int)Color.Blue);

            Console.ReadKey();

        }

        }
    }

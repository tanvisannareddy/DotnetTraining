using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays.program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 89, 90, 93, 94, 95, 98 };
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("subject{0} marks ={1}", i + 1, marks[i]);
            }

            foreach(var mrk in marks)
            {
                Console.WriteLine("Subject Marks = {0}", mrk);
            }

            string[] empls = new string[] { "rama", "anju", "vineetha", "rithika" };

            foreach (var emp in empls)
            {
                Console.WriteLine("employee -> {0}", emp);
            }

            var avgMarks = GetAverageMarks(marks);
            Console.WriteLine("Average of Marks = {0}", avgMarks);

            //Two-dimensional array

            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for(int i=0; i < 3; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
         //define a function to return the average of

        public static double GetAverageMarks(int[] marks)
        {
            int total = 0;
            double avg;

            for (int i = 0; i < marks.Length; i++)
                total = total + marks[i];

            avg = total / marks.Length;
            return avg;
        }

    }
}

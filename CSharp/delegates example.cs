using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_example_program
{
    class Program
    {
        public delegate void MathDelegate(float n1, float n2);

        public delegate void PrintHandler();
        public event PrintHandler Print;

        public void OnPrint()
        {
            Console.WriteLine("Printing is done!");
        }

        public  void Show()
        {
            Console.WriteLine("Inside Show method");
            Print();
        }
        static void Main(string[] args)
        {
            //Multicast Delegate

            MathDelegate mathdeleg = new MathDelegate(Add);

            mathdeleg += Subtract;
            mathdeleg += Multiply;
            mathdeleg += Divide;

            mathdeleg.Invoke(950, 95);


            Program objP = new Program();

            objP.Print += new PrintHandler(objP.OnPrint); //Registering OnPrint event handler with print event

            objP.Show();// raise the print event(defined inside the show method

            Console.ReadKey();

        }

        public static void Add(float n1, float n2)
        {
        
        Console.WriteLine("\nThe sum of {0} and {1} = {2}",n1,n2,n1+n2);
        }

        public static void Subtract(float n1, float n2)
        {
        Console.WriteLine("The difference of {0} and {1} = {2}",n1,n2,n1-n2);
        }

        public static void Multiply(float n1, float n2)
        {
        Console.WriteLine("The product of {0} and {1} = {2}",n1,n2,n1*n2);
        }

        public static void Divide(float n1, float n2)
        {
            Console.WriteLine("The quotient of {0} and {1} = {2}", n1, n2, n1 / n2);
        }
    
}
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_demo
{
    class Program
    {
        static void Main(string[] args) //entry point of csharp console application
        {
            Student stu = new Student()
            Student stu = new Student() (90,70)

                Stu1.GetTotal();

            Console.WriteLine("Salary without incentives: Rs {0}", salary);

            salary = emp.GetSalary(30, 800, 5000);
            Console.WriteLine("Salary with incentives: Rs {0}", salary);


            Manager objM =                                                                                                                                                                                   Manager();
            var ts = objM.GetPerks(30000, 5000);
            Console.WriteLine("Salary of manager Rs {0}", ts);

            Console.ReadKey();

        }
    }

    public class Student
    {
        public base double GetTotal(float n1, float n2) //this method can be overloaded with different signatures

        {
            double salary = n1+n2;
            return total;

        }

        public  base double GetSalary(float n1, float n2, double percentage);
        {
            double salary = ((n1 + n2) / total) / 100;

            return salary;
        }

        //This method will be override in some other derived class
        public virtual double GetPerks(float salary,float perks)//Getsalarty method is overloaded
        {
            double ts = salary + perks;
            return ts;
        }
    }

    public class Manager : Employee
    {
        public override double GetPerks(float salary,float perks) //signature remains same while overriding
        {
            //return base.GetPerks(salary, perks) * 1.10;  //'base' keyword refers to the base class

            double ts = 1.10 * (salary + perks);
            return ts;
        }
    }


}

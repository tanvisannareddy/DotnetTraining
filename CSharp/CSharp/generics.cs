using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generics_program
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList items = new ArrayList(100); //non genric collection class

            items.Add("Hello World");
            items.Add(10);
            items.Add(DateTime.Now);
            items.Add(true);

            foreach (object obj in items)
                Console.WriteLine(obj.ToString());

            List<int> myInts = new List<int>(); //Generic collection class

            myInts.Add(10);
            myInts.Add(80);
            //myInts.Add("Hi");

            myInts.Add(90);

            foreach (object obj in myInts)
                Console.WriteLine(obj.ToString());

            List<string> employees = new List<string>() { "Anders Helsberg", "Christian Nagel", "Jeffrey Richer",
                "Matthew McDonald", "Andrew Trolesan" };
            //collection Initialzer

            foreach (var emp in employees)
                Console.WriteLine(emp);

            Dictionary<int, string> fruits = new Dictionary<int, string>();
            fruits.Add(1, "Apple");
            fruits.Add(2, "Orange");
            fruits.Add(3, "Banana");
            fruits.Add(4, "Pineapple");
            fruits.Add(5, "Watermelon");

            foreach (KeyValuePair<int, string> kv in fruits)
            {
                Console.WriteLine("Key -> {0},value -> {1}", kv.Key, kv.Value);
            }

            //deleting an item from the collection 

            fruits.Remove(4);
            fruits.Add(4, "Grapes");

            foreach (KeyValuePair<int, string> Kv in fruits)
            {
                Console.WriteLine("Key -> {0},Value -> {1}", Kv.Key, Kv.Value);
            }

            SortedDictionary<int, string> gadgets = new SortedDictionary<int, string>();
            //sort all the items in ascending order and then retrieves them

            gadgets.Add(3, "Think pad");
            gadgets.Add(1, "Note pad");
            gadgets.Add(5, "Smart phone");
            gadgets.Add(4, "CD phone");
            gadgets.Add(2, "CDMicrophone");

            foreach (KeyValuePair<int, string> kv in gadgets)
            {
                Console.WriteLine("Key -> {0},Value -> {1}", kv.Key, kv.Value);

            }

            ArrayList employee1 = new ArrayList(100);

            employee1.Add("tanvi");
            employee1.Add(1);
            employee1.Add("tech");

            foreach (object obj in employee1)
            {
                Console.WriteLine(obj.ToString());
            }


            //Adding Employee Objects to the List collection
            List<Employee> Employees = new List<Employee>();

            Employees.Add(new Employee() { EmployeeID = 1, EmpName = "Anders", Department = "microsoft"});
            Employees.Add(new Employee() { EmployeeID = 2, EmpName = "jeffrey", Department = "tcs" });
            Employees.Add(new Employee() { EmployeeID = 3, EmpName = "robert", Department = "dell" });

            foreach (var emp in Employees)
            {
                Console.WriteLine("EmpID = {0},Name = {1},Department = {2}", emp.EmployeeID, emp.EmpName, emp.Department);
            }
            Console.ReadKey();

        }
    }

    public class Employee
    {
        public int EmployeeID
        {
            get;
            set;
        }

        public string EmpName
        {
            get;
            set;
        }

        public string Department
        {
            get;
            set;
        }

        public string ShowData()
        {
            return string.Format("EmpID: {0},EmpName: {1},DepaRTMENT: {2}", EmployeeID, EmpName, Department);
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer custom = new Customer() { CustomerID = 1, Customername = "tanvi", CustomerCountry = "dubai" };

            custom.ShowData();
        }
        public  class Customer
        {
            int cid;

            public int CustomerID
            {
                get { return cid; }
                set { cid = value; }
            }

            public string Customername
            {
                get;
                set;
            }
             public string CustomerCountry
            {
                get;
                set;
            }

            public void ShowData()
            {
                Console.WriteLine("CustomerID={0}", CustomerID);
                Console.WriteLine("Customername={0}", Customername);
                Console.WriteLine("CustomerCountry={0}", CustomerCountry);
            
            }
        }
    }
}

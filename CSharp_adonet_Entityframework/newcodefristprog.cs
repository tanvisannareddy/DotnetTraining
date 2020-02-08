using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;


namespace NewCodeFirstProg
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDBContext context = new CustomerDBContext();

            var customer = context.Customers;

            var customer1 = customer.Add(new customer()
            {
                customerID = 1,
                Name = "Badam Drink",
                Price = 99.99,
                Quantity = "500 ml",
                CategoryID = 1
            });

            var customer2 = customer.Add(new customer()
            {
                customerID = 2,
                Name = "Coffee Drink",
                Price = 99.99,
                Quantity = "250 ml",
                CategoryID = 1
            });

            var customer3 = customer.Add(new customer()
            {
                customerID = 3,
                Name = "Coke Drink",
                Price = 49.99,
                Quantity = "200 ml",
                CategoryID = 1
            });

           
            context.SaveChanges();



        }

    }

    public class customerDBContext : DbContext
    {
        public customerDBContext() :
        base("name=customerDBContext")
        { }

        public DbSet<customer> customers { get; set; }
        

    }

    public class customer
    {
        public int customerID { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Quantity { get; set; }

        public int CategoryID { get; set; }
    }
}
    
        
   

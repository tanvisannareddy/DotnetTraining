using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBankAcount;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI i1 = new ICICI();
            int AccType = (int)BankAccountTypeEnum.Saving;
            Console.WriteLine("Depositing 50000");
            i1.Deposit(50000);
            i1.GetBalance();

            ICICI i2 = new ICICI();
            int AccType2 = (int)BankAccountTypeEnum.Current;
            Console.WriteLine("Depositing 20000");
            i2.Deposit(20000);
            i2.GetBalance();

            i1.Transfer(i2, 5000);
            i1.GetBalance();
            i2.GetBalance();

            HSBC h1 = new HSBC();
            int AccType1 = (int)BankAccountTypeEnum.Saving;
            Console.WriteLine("Depositing 30000");
            h1.Deposit(30000);
            h1.GetBalance();

            HSBC h2 = new HSBC();
            int AccType3 = (int)BankAccountTypeEnum.Current;
            Console.WriteLine("Depositing 20000");
            h2.Deposit(20000);
            h2.GetBalance();

            h1.Transfer(h2, 20000);

            h1.GetBalance();
            h2.GetBalance();
            Console.ReadKey();
        }
    }
}

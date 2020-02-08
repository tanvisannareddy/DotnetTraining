using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankcomponent
{
    public class Savingsbank
    {
        public int BalanceComponent;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           

        public double Balance { get; set; }
        public double GetSimpleInterest( double pr,int duration,float rate )

        {
            var si = (pr * duration * rate) / 100;
            
            return si;
           
        }

        public  double GetBalance( double si)
        {
            double T = Balance + si;
            return T;
        }





        }
    }


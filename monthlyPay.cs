using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingProblem
{
    public static class monthlyPay
    {
        public static void monthlyPayment()
        {
            Console.WriteLine("write the principal amount");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write : Number of year of payment");
            double years = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("write : intrest");
            double rate = Convert.ToDouble(Console.ReadLine());
            double n = 12 * years;
            double r = rate/ (12*100);
            double x = 1 + r;
            double z = 1 / n; 
            double y = (int)Math.Pow(z,x); 
            double payment = (p * rate) /(1-y);
            Console.WriteLine(payment);
        }
        public static void Main(string[]strings)
        {
            Console.WriteLine("your monthly payment");
            monthlyPay.monthlyPayment();
        }

    }
}


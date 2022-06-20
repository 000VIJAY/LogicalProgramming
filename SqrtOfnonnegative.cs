using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingProblem
{
    public class SqrtOfnonnegative
    {
        public static void Coupen()
        {
            Console.WriteLine("write number whose squre root wants to find");
            double c =Convert.ToDouble(Console.ReadLine());
            double t =c;
            Console.WriteLine("value of t : " +t);
            double x= c / t;
            double epsilon = 1e-15;
            while (Math.Abs(t - x) > epsilon * t )
            {
                t = (t+x)/2;
            }
            Console.WriteLine("The accuracy of desired value : " + t);

        }
        public static void Main(string[]strings)
        {
            SqrtOfnonnegative.Coupen();
        }
    }
}


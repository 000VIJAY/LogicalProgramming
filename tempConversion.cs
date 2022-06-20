using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingProblem
{
    public class tempConversion
    {
        public static void degreeCelToDegreeFahrenheit()
        {
            Console.WriteLine("Tempraure Conversion unit Celsius to Fahrenheit ");
            double c = Convert.ToDouble(Console.ReadLine());
            double fh = (c * (9 / 5)) + 32;
            Console.WriteLine("Unit after conversion in Fahrenheit : " + fh);

        }
        public static void fahrenheitToDegreeCel()
        {
            Console.WriteLine("Temperature Conversion unit fahrenheit to celsius");
            double f = Convert.ToDouble(Console.ReadLine());
            double ch = (f - 32) * (5 / 9);
            Console.WriteLine("Unit after conversion in celsius : " + ch);
        }
        public static void Main(string[] strings)
        {
            Console.WriteLine("Enter temperature");
            tempConversion.fahrenheitToDegreeCel();
            tempConversion.degreeCelToDegreeFahrenheit();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1)
            Console.WriteLine("Hello");
            Console.WriteLine("Bala");
            Console.ReadKey();
            */

            /* 2)
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sum = "+(n1+n2));
            Console.ReadKey();
            */

            /* 3)
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            try
            {
                Console.WriteLine("Division = "+(n1 / n2));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
            */

            /* 4)
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.ReadKey();
            */

            /* 5)
            Console.WriteLine("Enter two numbers");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Num 1 = " + n1 + " Num 2 = " + n2);
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1 - n2;
            Console.WriteLine("Num 1 = " + n1 + " Num 2 = " + n2);
            Console.ReadKey();
            */


            /* 6)
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Multiplication = "+(n1*n2*n3));
            Console.ReadKey();
            */

            /* 7)
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Addition = " + (n1+n2));
            Console.WriteLine("Subtraction = " + (n1-n2));
            Console.WriteLine("Multiplication = " + (n1*n2));
            Console.WriteLine("Division = " + (n1/n2));
            Console.ReadKey();
            */

            /* 8)
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Multiplication Table of " + n1);
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(n1+" * "+i+" = "+n1*i);
            Console.ReadKey();
            */

            /* 9)
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double n3 = Convert.ToDouble(Console.ReadLine());
            double n4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Average = "+((n1+n2+n3+ n4)/4));
            Console.ReadKey();
            */

            /* 11)
            Console.Write("Enter your age : ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You look older than "+age);
            Console.ReadKey();
            */

            /* 12)
            int n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("{0} {0} {0} {0}",n1);
            Console.WriteLine();
            Console.Write("{0}{0}{0}{0}", n1);
            Console.ReadKey();
            */

            /* 13)
            int n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(n1 + "" + n1 + "" + n1);
            Console.WriteLine(n1 + " " + n1);
            Console.WriteLine(n1 + " " + n1);
            Console.WriteLine(n1 + " " + n1);
            Console.WriteLine(n1 + "" + n1 + "" + n1);
            Console.ReadKey();
            */

            /* 14)
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kelvin = " + (celsius+273));
            Console.WriteLine("Fahrenheit = " + (celsius*9/5+32));
            Console.ReadKey();
            */
        }
    }
}

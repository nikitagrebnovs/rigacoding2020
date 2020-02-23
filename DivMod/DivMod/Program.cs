using System;

namespace DivMod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            double a = 33333333333333333;
            double c = 2;
            double b = a % c;
            Console.WriteLine(b);

            Console.WriteLine("Enter number for verify");
            double number = Convert.ToDouble(Console.ReadLine())%2;
            
            if (number == 0)
            {
                Console.WriteLine("Number is perfect! ");
            }
            else
                Console.WriteLine("It's not..");



        }
    }
}

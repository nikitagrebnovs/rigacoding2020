using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            homework1();
            homework2();
        }

        static void homework2()
        {
            Random rnd = new Random();
            int number = rnd.Next(1,8);
            Console.WriteLine("Number is " + number + " and day is");

            if (number == 1)
                Console.WriteLine("Monday");
            else if (number == 2)
                Console.WriteLine("Tuesday");
            else if (number == 3)
                Console.WriteLine("Wednesday");
            else if (number == 4)
                Console.WriteLine("Thursaday");
            else if (number == 5)
                Console.WriteLine("Friday");
            else if (number == 6)
                Console.WriteLine("Saturday");
            else
                Console.WriteLine("Sunday");
        }

        static void homework1 ()
            {
            Console.WriteLine("Enter number for verify");
            double number = Convert.ToDouble(Console.ReadLine());

            if (number == 0)
                Console.WriteLine("Number is zero..");
            else
                Console.WriteLine(check(number));
            }
        static bool check(double a)
            {
            if (a > 0)
            {
                Console.WriteLine("Positive");
                return true;
            }
            else
            {
                Console.WriteLine("Negative");
                return false;
            }
            }

    }
}

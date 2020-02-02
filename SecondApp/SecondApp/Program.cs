using System;

namespace SecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
           //cilveks ievada skaitli
           // motode kas atgriez vai skaitlis ir pozitiv vai negativs
            


        }

        static void salidzinasana()
        {
            Console.WriteLine("Ievadiet skaitli pozitivu vai negativu");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(number(a));



        }

        static bool number(double a)
        {   
            


      
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
           

        }

        static void darb(double a)
        {
            bool x;
            if(a>0)
            {
                x = true;
            }
            else if(a<0)
            {
                x = false;
            }
            else
            {
                Console.WriteLine("numebr is 0");
            }
               

        }






        static void biggest()
        {

            darbibas(number(), number(), number());
        }

        static int number()
        {
            Console.WriteLine("Ievadiet skaitli!");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void darbibas(int a, int b, int c)
        {

            int biggest = 0;
            if (a > b && a > c)
            {
                biggest = a;
            }
            else if (b > c)
            {
                biggest = b;
            }
            else biggest = c;

            Console.WriteLine("Rezultats ir " + biggest);
        }

        static void piemeruMain()
        {
            //saskaitisna 
            //ievads main metode, padodam uz musu izeidoto ka prametru
            //izvadne notiek tur

            //2
            //ievadne notiek musu izveidota metode
            //rezeltatu atgriezam ar return un izvadam main

            //3
            //apvienojam 1 un 2
            //musu izvaidotaja metode notiek tikai darbiba
            //visu ievadne/izvadne notiek main(gan parametri gan return)
            Console.WriteLine("Ievadiet pirmo skaitli ");
            String input1 = Console.ReadLine();
            Console.WriteLine("Ievadiet otro skaitli ");
            String input2 = Console.ReadLine();

            double first = Convert.ToDouble(input1);
            double second = Convert.ToDouble(input2);

            //1 variants
            piemers1(first, second);


            //2 variants
            double a = piemers2();
            Console.WriteLine(a);


            //3 variants
            Console.WriteLine(piemers3(first, second));
        }


        static void piemers1(double a, double b)
        {
            double sum;
            sum = a + b;

            Console.WriteLine("Sask. summa ir " + sum);

        }

        static double piemers2()
        {
            Console.WriteLine("Ievadiet pirmo skaitli ");
            String input1 = Console.ReadLine();
            Console.WriteLine("Ievadiet otro skaitli ");
            String input2 = Console.ReadLine();
            double first = Convert.ToDouble(input1);
            double second = Convert.ToDouble(input2);


            return first + second;
        }

        static double piemers3(double a, double b)
        {

            return a + b;

        }

        static String piemers5()
        {
            Console.WriteLine("Ievadiet kaut ko ");
            String ievads = Console.ReadLine();

            return ievads;

        }

        static void calculator()
        {
            //kalukulators
            //cilveks ievadas 2 skaitlus
            // izvelas darbibu
            //uz ekrana izvada rezultatu


            int moves = 10;



            while (moves != 0)
            {
                Console.WriteLine("Ievadiet pirmo skaitli!");
                String first = Console.ReadLine();
                Console.WriteLine("Ievadiet otro skaitli!");
                String second = Console.ReadLine();

                double ConvFirst = Convert.ToDouble(first);
                double ConvSecond = Convert.ToDouble(second);
                double answer;



                Console.WriteLine("Iezvēlaties darību + - / *");
                String symbol = Console.ReadLine();

                if (symbol == "+")
                {

                    answer = ConvFirst + ConvSecond;
                    Console.WriteLine("Risinājums ir " + answer);


                }

                else if (symbol == "-")
                {

                    answer = ConvFirst - ConvSecond;
                    Console.WriteLine("Risinājums ir " + answer);
                }

                else if (symbol == "/")
                {
                    answer = ConvFirst / ConvSecond;
                    Console.WriteLine("Risinājums ir " + answer);
                }

                else if (symbol == "*")
                {
                    answer = ConvFirst * ConvSecond;
                    Console.WriteLine("Risinājums ir " + answer);
                    Console.WriteLine("Turpinām talāk? y / n");
                    String end = Console.ReadLine();
                    if (end == "n")
                    {
                        moves = 0;
                    }
                    else moves++;
                }
                else
                {

                    Console.WriteLine("Nepareiza darbība");
                    Console.WriteLine("Turpinām talāk? y / n");
                    String end = Console.ReadLine();
                    if (end == "n")
                    {
                        moves = 0;
                    }
                    else moves++;



                }
            }
        }

        static void biggestNumber()
        {
            //ievada trīs skaitļus
            // Jāizvadaa lielākais

            Console.WriteLine("Ievadiet pirmo skaitli");
            String input1 = Console.ReadLine();
            Console.WriteLine("Ievadiet otro skaitli");
            String input2 = Console.ReadLine();
            Console.WriteLine("Ievadiet trešo skaitli");
            String input3 = Console.ReadLine();

            double first = Convert.ToDouble(input1);
            double second = Convert.ToDouble(input2);
            double third = Convert.ToDouble(input3);

            if (first > second)
            {
                if (first > third)
                    Console.WriteLine("Lielākais skaitlis ir " + first);
                else if (first > third)
                    Console.WriteLine("Lielākais skaitlis ir " + third);

            }
            else if (second > third)
            {
                Console.WriteLine("Lielākais skaitlis ir " + second);

            }
            else
                Console.WriteLine("Lielākais skaitlis ir " + third);



        }

    }
}

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            uzdevums4();



        }

        static void uzdevums4()
        {
            //*
            //**
            //***
            //****
            //#################
            //*
            //**
            //***
            //****

            String zv = "*";

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < i; j++)
                {

                    Console.Write(zv);
                }
                Console.WriteLine();

            }

            for (int i = 5; i > 0; i--)
            {

                for (int j = 0; j < i; j++)
                {

                    Console.Write(zv);
                }
                Console.WriteLine();

            }

            String zv2 = "###################";
            for (int i = 0; i < 11; i++)
            {
                for(int j=20;j>i;j--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(zv2.Substring(0, i));
            }

            for(int i=10;i>0;i--)
            {
                for (int j = 20; j > i; j--)
                {
                    Console.Write(" ");
                }

                Console.WriteLine(zv2.Substring(0, i));
            }

        }



        static void uzdevums3()
        {
            //ievada skaitli
            //ievada pakapi
            //izvadam rez

            Console.WriteLine("Enter number 1!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2!");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for(int i=1;i<=b;i++)
            {
                sum = sum * a;
            }
            Console.WriteLine(a+"^"+b+"="+ sum);

        }



        static void uzdevums2()
        {
            int sum = 0;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("Enter number");
                sum += (Convert.ToInt32(Console.ReadLine()));

            }
            Console.WriteLine("Sum is " + sum);

        }




        
        static void uzdevums1()
        {
            //ar for cikla palidzibu. sasummet skaitlus no 1 lidz 10
            // izvadidt summu


            double sum = 0;

            for (int i = 1; i < 11; i++)
            {

                sum += i;





            }

            Console.WriteLine("summa " + sum);




        }


        static void forLoopEx()
        {

            /* for (int i = 0; i < 7; i++)
             {
                 Console.WriteLine("Enter word");
                 Console.WriteLine(Console.ReadLine());
             }*/


            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}


﻿using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //cilveks ievada skaitli
            //parbaudam vai ir > par 5
            //ja ir izvadam ##
            //ja nav #

            Console.WriteLine("Ievadiet skaitli pārbaudei!");
            String number = Console.ReadLine();

            int number2 = Convert.ToInt32(number);
            if(number2>5 && number2!=9)
            {
                Console.WriteLine("##");s
            }
            else
            {
                Console.WriteLine("#");
            }
            Console.ReadLine();







        }

        static void piemers()
        {
            int a = 5;
            int b = 7;

            int c = a + b;

            Console.WriteLine("Ievadiet nepieciešamo skaitli!");
            String name = Console.ReadLine();

            int convertNr = Convert.ToInt32(name);

            c = convertNr + 10;

            Console.WriteLine("Jaunais skaitlis ir "+c);

            String virkne1 = "vertiba ";
            String virkne2 = "ir";

            String virkne3 = virkne1 + virkne2;
            Console.WriteLine(virkne3);

        }

        static void vecumaNoteiksana()
        {

            //paprasa, kurs gads ir
            //lietotajs ievada
            //prassam kura gada ir dzimis
            //lietotajs ievada
            //atnemat skaitli lai uzzinatu vecumu
            //izvadit vecums ir..


            Console.WriteLine("Ievadiet gadu ");
            String nowYear = Console.ReadLine();
            Console.WriteLine("Ievadiet jūsu dzimšanas gadu");
            String bornYear = Console.ReadLine();

            int convert1 = Convert.ToInt32(nowYear);
            int convert2 = Convert.ToInt32(bornYear);
            int age = convert1 - convert2;

            Console.WriteLine("Jūsu vecums ir " + age);
            Console.ReadLine();



        }

        static void tapat()
        {
            int a = 5;
            int b = 8;

            Console.WriteLine("Vai a ir lielaks?? ");
            if (a > b)
            {
                Console.WriteLine("lielaks");

            }
            else
            {
                Console.WriteLine("nava");
            }

            Console.ReadLine();
        }
    }
}

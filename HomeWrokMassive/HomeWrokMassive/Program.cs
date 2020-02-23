using System;

namespace HomeWrokMassive
{
    class Program
    {
        static void Main(string[] args)
        {
            uzd1();
            uzd2();
            uzd3();





        }


        static void uzd4(int[] a)
        {
            Console.WriteLine("Nepāra skaitļi");
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] % 2 != 0)
                    Console.WriteLine(a[i]);
            }


        }



        static void uzd3()
        {
            Console.WriteLine("Enter lenght of array!");
            int lenghtOf = Convert.ToInt32(Console.ReadLine());
            int[] mas3 = new int[lenghtOf];


            for (int i = 0; i < mas3.Length; i++)
            {
                Console.WriteLine("Enter massive " + (i + 1) + " number");
                mas3[i] = Convert.ToInt32(Console.ReadLine());
            }

            print(mas3);
            uzd4(mas3);


        }

        static void uzd2()
        {
            int[] mas2 = new int[5];
            int counter = 0;
            for(int i=1;i<11;i++)
               
            {
                
                if (i % 2 == 0)
                {
                    
                    mas2[counter] = i;
                    counter++;
                }

            }

            print(mas2);

        }


        public static void uzd1()
        {
            string[] mas1 = new string[6];
            for (int i = 0; i < mas1.Length; i++)
                mas1[i] = "######";
            for (int i = 0; i < mas1.Length; i++)
                Console.WriteLine(mas1[i]);

        }


        static void print(int[] a)
        {

            Console.WriteLine("########## ARRAY ##########");
            for (int i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);

        }
        
    }
}

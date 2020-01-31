using System;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter string for test ");
            String word = Console.ReadLine();

            int letterCount = word.Length;

            if(letterCount<5 || word=="aaaaaaaa")
            {

                Console.WriteLine("Congrats!!");

            }

            else
            {
                Console.WriteLine("Try again! ");
               
            }

            Console.ReadLine();




        }
    }
}

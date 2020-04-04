using System;

namespace DAY11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            wordCatch();


        }

        static void wordCatch()
        {
            Console.WriteLine("Enter your word");
            String word = Console.ReadLine();
            char[] chars = word.ToCharArray();

            Console.Write("Word is " + word);
            Console.WriteLine("");
            printArray(chars);


            GameForPlayerTwo(chars);Console.Write("Word is " + word);


        }


        static void GameForPlayerTwo(char[] word)
        {
            Console.Clear();
            bool winner = false;
            char buffer;
            int counter = 0;
            int winnerPoints = 0;
            int counterWrong = 0;
            Console.WriteLine("Helo in the game!");
            Console.WriteLine("You need to try to get the word, letter by letter!!!");

            while (winner == false)
            {

                
                Console.WriteLine("Enter " + (counter+1) + " letter");
                buffer = Convert.ToChar(Console.ReadLine());
                if(buffer == word[counter])
                {
                    Console.WriteLine("Good");
                    counter++;
                    winnerPoints++;
                    if (winnerPoints == word.Length)
                    {
                        Console.WriteLine("Congratulations! You are the winner!");
                        winner = true;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong");
                    counterWrong++;
                    if (counterWrong == 5)
                    {
                        Console.WriteLine("You loose :(");
                        winner = true;
                    }

                }
               
                



            }



        }





        static char[] printArray(char[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i] + " ");
            }

            return array;
        }









        static void uzd1()
        {
            int[] masiv = new int[10];
            makeArray(masiv);
            printArray(masiv);
            bubbleSort(masiv);
            printArray(masiv);

        }

        static int[] bubbleSort(int[] array)
        {

            double lenght = array.Length;

            for(int i=0;i<lenght-1;i++)
                for(int j=0;j<lenght-i-1;j++)
                {
                    
                    if(array[j]>array[j+1])
                    {
                        var buffer = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buffer;
                    }
                }


            return array;
        }

       

        static void makeArray(int[] masiv)
        {
            
            for (int i = 0; i < masiv.Length; i++)
            {
                Console.WriteLine("Enter array" + (i + 1)+" number");
                masiv[i] = Convert.ToInt32(Console.ReadLine());
            }


        }

        static void printArray(int[] masiv)
        {
            Console.WriteLine("###### ARRAY ######");
            for(int i=0;i<masiv.Length;i++)
                Console.Write(masiv[i] +" ");
        }




       
    }
}

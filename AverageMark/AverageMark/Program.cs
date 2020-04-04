using System;

namespace AverageMark
{
    class Program
    {
        static void Main(string[] args)
        {
            array();
            

        }

        static void array()
        {

            int[] array = new int[20];
            for(int i=0;i<array.Length;i++)
            {
                Random random = new Random();
                array[i] = random.Next(1, 10);
            }
            print(array);
            average(array);
            labiniekiUnTeicamnieki(array);
            nepara(array);
            

        }

        static void average(int[] array)
        {


            int boofer;

            for(int i=0;i<array.Length;i++)
                for(int j=0;j<array.Length-i-1;j++)
            {
                    if(array[j]>array[j+1])
                    {
                        boofer = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = boofer;
                    }

            }
            print(array);

            //Average
            int sum = 0;
            for(int i=0;i<array.Length;i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Average mark is - " + (sum / array.Length));

        }


        static void print(int[] array)
        {
            Console.WriteLine("####### List #######");
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i] + "");
            }
        }

        static void labiniekiUnTeicamnieki(int[] array)
        {
            int labi = 0; 
            int teicami=0;

            for(int i=0;i< array.Length;i++)
            {
                if(array[i]==7)
                {
                    labi++;
                }
                else if(array[i]>7)
                {
                    teicami++;
                }

            }

            Console.WriteLine("Labinieku ir - " + labi);
            Console.WriteLine("Teicamnieku ir - " + teicami);

        }

        static void nepara(int[] array)
        {
            int counter = 0;
            int[] array2 = new int[array.Length];

            for(int i=0;i<array.Length;i++)
            {
                if (array[i] % 2 != 0)
                    array[i] =0;
            }
            print(array);
        }

    }
}

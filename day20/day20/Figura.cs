using System;
using System.Collections.Generic;
using System.Text;

namespace day20
{
    abstract class Figura
    {

        public double summa = 0;

        public double platums, augstums;

        public void printSum()
        {
            Console.WriteLine("Laukums ir " + summa);
        }

        public void TestIzvade()
        {
            Console.WriteLine("TEST");

        }

        public abstract void laukums();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace day21
{
    abstract class Transports
    {
        public double tilpumsIpasiba;
        public String krasa;

        public void Move()
        {
            MakeSound();
            tilpums();
            printKrasa();

        }

        public void tilpums()
        {
            Console.WriteLine("Tilpums ir "+tilpumsIpasiba);
        }

        public void printKrasa()
        {
            Console.WriteLine("Krāsa ir " + krasa);
        }

        public abstract void MakeSound();

        public abstract void Refill();


    }
}

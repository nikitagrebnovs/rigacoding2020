using System;
using System.Collections.Generic;
using System.Text;

namespace day21
{
    class bycicles:Transports
    {
        public bycicles()
        {
            this.tilpumsIpasiba = 0;
            this.krasa = "Melna";

        }

        public override void MakeSound()
        {

            Console.WriteLine("zum zum");


        }

        public override void Refill()
        {
            Console.WriteLine("There is no fuel tank..");

        }


    }
}

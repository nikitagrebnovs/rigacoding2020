using System;
using System.Collections.Generic;
using System.Text;

namespace day21
{
    class motorbike:Transports
    {

        public motorbike()
        {
            this.tilpumsIpasiba = 1.4;
            this.krasa = "Balta";

        }


        public override void MakeSound()
        {

            Console.WriteLine("chuh chuh");


        }

        public override void Refill()
        {
            Console.WriteLine("Tank is almost empty 3L, now is full.. ");

        }


    }
}

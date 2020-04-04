using System;
using System.Collections.Generic;
using System.Text;

namespace day21
{
    class car:Transports
    {
        public car()
        {
            this.tilpumsIpasiba = 2.5;
            this.krasa = "sarkana";
        }


        public override void MakeSound()
        {

            Console.WriteLine("Vrum Vrum mazafaka");


        }

        public override void Refill()
        {
            Console.WriteLine("Tank is almost empty 10L, now is full.. ");

        }


    }
}

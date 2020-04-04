using System;
using System.Collections.Generic;
using System.Text;

namespace day20
{
    class _3sturis : Figura
    {

        public _3sturis(double a,double b)
        {
            this.platums = a;
            this.augstums = b;
        }

         

        public override void laukums()
        {
            this.summa = platums * augstums*0.5;
        }


        public new void TestIzvade()
        {
            Console.WriteLine("Jauna testa izvade");

        }



    }
}

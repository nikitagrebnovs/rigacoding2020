using System;
using System.Collections.Generic;
using System.Text;

namespace day20
{
    class _4sturis: Figura
    {
        public _4sturis(double a, double b)
        {
            this.platums = a;
            this.augstums = b;
        }


        public override void laukums()
        {

            this.summa = platums * augstums;

        }



    }
}

using System;

namespace day21
{
    class Program
    {
        static void Main(string[] args)
        {

            car audik = new car();

            audik.Move();
            audik.Refill();

            motorbike suzuki = new motorbike();

            suzuki.Move();
            suzuki.Refill();

            bycicles aist = new bycicles();

            aist.Move();
            aist.Refill();
           


        }
    }
}

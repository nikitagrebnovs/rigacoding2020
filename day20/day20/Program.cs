using System;

namespace day20
{
    class Program
    {
        static void Main(string[] args)
        {

            _4sturis chetri=new _4sturis(10,7);

            _3sturis tris = new _3sturis(10,7);

            chetri.laukums();
            chetri.printSum();

            tris.laukums();
            tris.printSum();

            chetri.TestIzvade();
            tris.TestIzvade();

            aprekins apr = new aprekins();
            apr.Dalisana(3, 4);
            apr.Dalisana(3.4, 4);

            String test = apr.Dalisana();


        }
    }
}

using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {   
            Cartao cartao = new Cartao();
            Console.WriteLine(cartao.aprovarCompra());

            MasterCard master = new MasterCard();
            master.parcelas=4;
            Console.WriteLine(master.ComprarComDescontoMastercard(60f));



        }
    }
}

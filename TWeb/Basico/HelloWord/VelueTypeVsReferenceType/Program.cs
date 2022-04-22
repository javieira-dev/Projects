using System;

namespace VelueTypeVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            //passagem por valor
            int numero1 = 3;
            int numero2 = numero1;
            numero1 = 5;

            Console.WriteLine("NUmero 1: " + numero1 + " NUmero 2 = " + numero2);

            Console.WriteLine("========================================================================");

            //passagem por referencia
            Teste teste1 = new Teste();
            teste1.Quantidade = 3;
            Teste teste2 = teste1;
            teste2 = teste1;
            teste1.Quantidade = 5;
            Console.WriteLine("Teste1.quantidade =  "+ teste1.Quantidade + " Teste2.quantidade = " + teste2.Quantidade);
            Console.WriteLine("======================================================================");
            //descobrir o tipo da variável
                int minhaVariavel = 10;
                //Aparece o tipo da variável
                Console.WriteLine(minhaVariavel.GetType());

            //inferência
            Console.WriteLine("=====================================================================");
            Console.WriteLine("INFERENCIA");

            var inteiro1 = 4;
            Console.WriteLine("Inteiro 1: " + inteiro1);

    }
    }

    class Teste
    {
        public int Quantidade;
    }
}

using System;

namespace BoxingVsUmboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing Umboxing

            //boxing
            int inteiro1 = 1;
            object objeto1 = inteiro1;
            Console.WriteLine(objeto1);
            //joga pra memória heap quando coloca ela no tipo objeto, 
            //passagem de valor da stack para a heap

            Console.WriteLine("================================================");
            //Umboxing
            //ocorre o contrário, pega uma variável que é uma referenceType (o object que está armazenado na Heap)
            //e copiou o valor para a memória stack pois quem está recebendo o valor é uma variável primitiva
            //- que é o tipo int
            int inteiro2 = (int)objeto1;
            Console.WriteLine("INteiro 2 = " + inteiro2);

        }
    }
}

using System;

namespace Consoleaula1
{
    class Program
    {
        static void Main(string[] args)
        {

            var conta1 = new conta_corrente("João Silva", 1234, 1000.00);
            


            Console.WriteLine("Detalhes iniciais das contas:");
            Console.WriteLine(conta1.GetdetailAccount());
           


            Console.WriteLine("\nRealizando operações na conta1...");


            conta1.Saque(200);
            Console.WriteLine("\nApós saque de R$ 200,00 da conta1:");
            Console.WriteLine(conta1.GetdetailAccount());


            conta1.Deposito(500);
            Console.WriteLine("\nApós depósito de R$ 500,00 na conta1:");
            Console.WriteLine(conta1.GetdetailAccount());


            
            Console.WriteLine("\nApós transferência de R$ 300,00 de conta1 para conta2:");
            Console.WriteLine(conta1.GetdetailAccount());
         


            conta1.Saque(1500);
            Console.WriteLine("\nTentativa de saque de R$ 1500,00 na conta1 (Saldo insuficiente):");
            Console.WriteLine(conta1.GetdetailAccount());
        }
    }
}




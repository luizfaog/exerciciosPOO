using System;

namespace exercicioGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo;
            int transacao;

            Console.WriteLine("Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial: s ou n");
            string depositoInical = (Console.ReadLine());
            if (depositoInical == "s" || depositoInical == "sim" || depositoInical == "S")
            {
                Console.WriteLine("informe o valor do deposito inicial: ");
                saldo = double.Parse(Console.ReadLine());
            }
            else
                saldo = 0.0;
            
            Conta conta1 = new Conta(numero,titular, saldo);

            Console.WriteLine("DADOS DA CONTA: ");
            Console.WriteLine(conta1.ToString());

            do
            {
                Console.WriteLine("Voce deseja fazer um depósito, saque ou sair? deposito (0) saque (1) Sair (2)");
                transacao = int.Parse(Console.ReadLine());
                if (transacao == 0)
                {
                    Console.WriteLine("Informe o valor de depósito: ");
                    double valor = double.Parse(Console.ReadLine());
                    conta1.SetDeposito(valor);
                    Console.WriteLine("DADOS ATUALIZADOS: ");
                    Console.WriteLine(conta1.ToString());
                }
                else if(transacao == 1)
                {
                    Console.WriteLine("Informe o valor de saque: ");
                    double valor = double.Parse(Console.ReadLine());
                    conta1.SetSaque(valor);
                    Console.WriteLine("DADOS ATUALIZADOS: ");
                    Console.WriteLine(conta1.ToString());

                }
                       
            } while (transacao != 2);

            Console.WriteLine("Obrigado e volte sempre!");

        }
    }
}

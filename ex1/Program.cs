using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("Bem vindo ao banco do Kappa");

            ContaCorrente conta1 = new ContaCorrente();

            Console.WriteLine("Digite o nome do títular:");
            conta1.titular = Console.ReadLine();
            Console.WriteLine("Digite o número da agência:");
            conta1.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número da conta:");
            conta1.numeroConta = int.Parse(Console.ReadLine());
            conta1.Depositar(1000);
            Console.WriteLine("Quando deseja sacar?");
            double valor = double.Parse(Console.ReadLine());
                bool resultado = conta1.Sacar(valor);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Titular: {conta1.titular}");
            Console.WriteLine($"Agência: {conta1.agencia}");
            Console.WriteLine($"Número da conta: {conta1.numeroConta}");
            Console.WriteLine($"Saldo da conta: {conta1.saldo}");
            Console.WriteLine("--------------------------------------");

            ContaCorrente conta2 = new ContaCorrente();

            Console.WriteLine("Digite o nome do títular:");
            conta2.titular = Console.ReadLine();
            Console.WriteLine("Digite o número da agência:");
            conta2.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número da conta:");
            conta2.numeroConta = int.Parse(Console.ReadLine());
            conta2.Depositar(3000);
            Console.WriteLine("Quando deseja sacar?");
            double valor2 = double.Parse(Console.ReadLine());
            conta2.Sacar(valor2);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Titular: {conta2.titular}");
            Console.WriteLine($"Agência: {conta2.agencia}");
            Console.WriteLine($"Número da conta: {conta2.numeroConta}");
            Console.WriteLine($"Saldo da conta: {conta2.saldo}");
            Console.WriteLine("--------------------------------------");
            bool resultadoTransferencia = true;
            do{
            Console.WriteLine("Quanto deseja transferir para conta 2?");
            double valorTransferencia = double.Parse(Console.ReadLine());
            resultadoTransferencia = conta1.Transferir(valorTransferencia, conta2);

            }while (resultado != true);
            Console.WriteLine("-----Valores após a transferência-----");
            Console.WriteLine($"Saldo da conta 1: {conta1.saldo}");
            Console.WriteLine($"Saldo da conta 2: {conta2.saldo}");


        }
    }
}

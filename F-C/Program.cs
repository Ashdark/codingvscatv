using System;

namespace F_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;
            string name;
            string surname;
            string resposta1;

            int fahrenheit;
            int celsius;


            bool repetir = true;


            Console.Clear();
            Console.WriteLine("Seja bem vindo ao conversor de Celsius para Fahrenheit/Fahrenheit para Celsius!");
            Console.WriteLine("Digite seu nome abaixo:");
            name = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome abaixo:");
            surname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Seja bem vindo senhor(a) {0} {1}!", name, surname);

            while (repetir)
            { 
            Console.WriteLine("Digite a medida que quer converter (Fahrenheit (F-C) ou Celsius (C-F))");
            resposta = Console.ReadLine();
            if (resposta.Equals("F-C", StringComparison.CurrentCultureIgnoreCase)){
                Console.WriteLine("Certo, vamos começar a converter Fahrenheit para Celsius!");
                Console.WriteLine("Digite o valor em Fahrenheit que deseja converter:");
                fahrenheit = int.Parse(Console.ReadLine());
                Console.WriteLine("O valor {0}F para Celsius, ficará {1}°C", fahrenheit, ((fahrenheit-32)/1.8));
                Console.WriteLine("-------------------------------------");
            }
            if (resposta.Equals("C-F", StringComparison.CurrentCultureIgnoreCase)){
                Console.WriteLine("Certo, vamos começar a converter Celsius para Fahrenheit!");
                Console.WriteLine("Digite o valor em Celsius que deseja converter:");
                celsius = int.Parse(Console.ReadLine());
                Console.WriteLine("O valor {0}°C para Fahrenheit, ficará {1}F", celsius, ((celsius*1.8)+32));
                Console.WriteLine("------------------------------------------"); }
            
            Console.WriteLine("Deseja fazer outra operação?");
            resposta1 = Console.ReadLine();

            if (resposta1.Equals("sim", StringComparison.CurrentCultureIgnoreCase)){
                repetir = true;
             } else if (resposta1.Equals("não", StringComparison.CurrentCultureIgnoreCase)){
                 Console.WriteLine("Obrigado por usar o programa!");
                 repetir = false;

             }
            }
        }
    }
}

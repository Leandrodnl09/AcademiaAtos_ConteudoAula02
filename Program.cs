namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            // Condições IF, Condições booleanas;
            if (num > 0) 
            {
                Console.WriteLine("O numero digitado é POSITIVO!");
            }
            else if (num < 0)
            {
                Console.WriteLine("O numero digitado e NEGATIVO!");
            }
            else
            {
                Console.WriteLine("O numero é 0!");
            }


            Console.Write("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) // Comando para saber so o resto da divisão é igual a 0;
            {
                Console.WriteLine("O numero digitado é PAR!");
            }
            else
            {
                Console.WriteLine("O numero digitado é IMPAR!");
            }

            if (x % 2 == 0) // Comandos para saber se os numeros são divisiveis;
            {
                Console.WriteLine("O numero é divisivel por 2!");
            }
            if (x % 4 == 0)
            {
                Console.WriteLine("O numero é divisivel por 4!");
            }
            if (x % 8 == 0)
            {
                Console.WriteLine("O numero é divisivel por 8!");
            }


            bool b;

            b = 5 > 5;
            b = 5 >= 5;
            b = 5 < 2;


            // Comando para saber se usuário é maior ou menor de idade;
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18) 
            {
                Console.WriteLine("Usuário MAIOR de idade!");
            }
            else
            {
                Console.WriteLine("Usuário MENOR de idade!");
            }


            // Calculadora básica;
            Console.WriteLine("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int opcao = int.Parse(Console.ReadLine());

            double resultado = 0;
            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("O resultado é: " + resultado);
        }
    }
}
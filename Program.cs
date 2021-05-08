using System;

namespace IMC_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" --- Índice de Massa Corporal ---\n");

            double altura, peso, resultado;

            Console.Write("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

            Console.Write("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            resultado = peso / Math.Pow(altura, 2);

            int novoResultado = Convert.ToInt32(resultado);

            if (novoResultado < 17)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{novoResultado:N1}Kg/m² Você está muito abaixo do peso ideal.");
            }

            else if (novoResultado <= 18.49)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"{novoResultado:N1}Kg/m² abaixo do peso ideal.");
            }
            else if (novoResultado <= 24.99)
            {
                Console.WriteLine($"{novoResultado:N1}Kg/m² peso normal");
            }
            else if (novoResultado <= 29.99)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{novoResultado:N1}Kg/m² você está acima do peso.");
            }
            else if (novoResultado <= 34.99)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{novoResultado:N1}Kg/m² Obesidade 1.");
            }
            else if (novoResultado <= 39.99)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{novoResultado:N1}Kg/m² Obesidade 2 Severa");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{novoResultado:N1}Kg/m² Obesidade tipo 3 Mórbida");
            }

            Console.ResetColor();
        }
    }
}

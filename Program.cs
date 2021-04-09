using System;

namespace IMC_DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" --- Índice de Massa Corporal ---\n");

            double altura,peso,resultado;

            Console.Write("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

             Console.Write("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            resultado = peso / Math.Pow(altura, 2);

             int novoResultado = Convert.ToInt32(resultado);

            if (novoResultado <17)
            {
             Console.WriteLine($" {novoResultado:N1} Você está muito abaixo do peso ideal.");
            }

              else if (novoResultado <=18.49)
            {
                Console.WriteLine($"{novoResultado:N1} abaixo do peso");
            }
              else if (novoResultado <=24.99)
            {
                Console.WriteLine($"{novoResultado:N1} peso normal");
            }
             else if (novoResultado <=29.99)
            {
                Console.WriteLine($"{novoResultado:N1} acima do peso.");
            }
             else if (novoResultado <=34.99)
            {
                Console.WriteLine($"{novoResultado:N1} Obesidade 1.");
            }
             else if (novoResultado <=39.99)
            {
                Console.WriteLine($"{novoResultado:N1} Obesidade 2 Severa");
            }

            else
            {
             Console.WriteLine($"{novoResultado:N1} Obesidade tipo 3 Mórbida");
            }
        }
    }
}

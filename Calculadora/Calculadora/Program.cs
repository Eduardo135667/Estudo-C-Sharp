using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer:");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int nun1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int nun2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = Adicao(nun1, nun2);
                        break;
                    }
                case 2:
                    {
                        resultado = Subtracao(nun1, nun2);
                        break;
                    }
                case 3:
                    {
                        resultado = Multiplicacao(nun1, nun2);
                        break;
                    }
                case 4:
                    {
                        resultado = Divisao(nun1, nun2);
                        break;
                    }

                default:
                    Console.WriteLine("Número Invalido, digite outro numero.");
                    break;

            }

            Console.WriteLine("O resultado da operação {0} e {1} é: {2}", nun1, nun2, resultado);

            Console.ReadLine();

        }





        public static int Adicao(int numero1, int numero2)
        {
            int result = numero1 + numero2;
            return result;
        }

        public static int Subtracao(int numero1, int numero2)
        {
            int result = numero1 - numero2;
            return result;
        }

        public static int Multiplicacao(int numero1, int numero2)
        {
            int result = numero1 * numero2;
            return result;
        }

        public static int Divisao(int numero1, int numero2)
        {
            int result = numero1 / numero2;
            return result;
        }

    }

}


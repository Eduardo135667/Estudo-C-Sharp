using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Condição Simples (if-else)
            int valor = 25;

            if (valor < 5)
            {
                Console.WriteLine("Condição Verdadeira");
            }
            #endregion

            #region Encadeadas (if-else if- else)
            else if (valor >= 5 && valor < 10)
            {
                Console.WriteLine("Condição alternativa 1");
            }
            else if (valor >= 10 && valor < 20)
            {
                Console.WriteLine("Condição alternativa 2");
            }
            else
            {
                Console.WriteLine("Condição alternativa final");
            }
            #endregion

            #region Condição aninhada
            //int numero = 10;

            //if (numero > 5)
            //{
            //  Console.WriteLine("O número é maior que 5");

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(" é também é par");
            //    }
            // }
            /// else
            //{
            //   Console.WriteLine(" mas não é par.");
            //
            //}
            #endregion

            #region Operador Ternário

            int numero = 10;
            string mensagem = "";

            // condição ? true : false;

            mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";


            //if (mensagem > 5)
            //{
            //    mensagem = "Maior que 5";
            //}
            //else
            //{
            //    mensagem = "Menor que 5";
            //}
            
            Console.WriteLine(mensagem);
            #endregion
            Console.ReadKey();
        }
    }
}

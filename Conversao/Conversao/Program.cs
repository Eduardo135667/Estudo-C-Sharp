using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region conversão Implicita 
            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500f;
            //int num4 = (int)num3;
            #endregion

            #region Metodo Parse
            //string txtNumero = "1985";

            //int numero = int.Parse(txtNumero);

            //byte num1 = byte.Parse("120");

            //double num2 = double.Parse("125623,57");


            #endregion

            #region Classe Convert

            string texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C');
            #endregion

            Console.WriteLine(num2);
            Console.ReadKey();
        }
    }
}

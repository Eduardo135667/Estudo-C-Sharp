namespace Variaveis
{
    class Program
    {

        enum Notas
        {
            Minimo = 60, 
            Media = 70, 
            Maxima = 100
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {
            #region Numeros Integrais
            // Integral assinado
            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short nun2 = 20; // 16 bits, -32.768 a 32.767
            //int nun3 = 30; // 32 bits, -2.147.483.648 a 2.147.483.647
            //long num4 = 40L; // 64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            // Integral se m sinal
            //byte num5 = 10; // 8 bits, intervalo de 0 a 255
            //ushort num6 = 20; // 16 bits, de 0 a 65.535
            //uint num7 = 30; // 32 bits, de 0 a 4.2294.967.295
            //ulong num8 = 40L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            //sbyte numero;
            //umero = 100;

            //numero = 120;
            //numero = num1;
            #endregion

            #region Numeros reais
            //float real1 = 100.75f; // 32 bits, intervalo de 1,5 x 10-45 a 3,4 x 1038, precisão de 7 digitos
            //double real2 = 500.454;
            //decimal real3 = 752538.457m;

            //double valor;
            //valor = 500;
            #endregion

            #region Caractere
            //char letra = '\u0061';
            //char escape = '\n';
            //Console.WriteLine(letra);
            //Console.ReadKey();
            #endregion

            #region Boolean
            //bool verificar = false;
            //verificar = true;
            #endregion

            #region String (Cadeia de Caracteres)
            //string texto = "Eduardo\n Artigos 1985 @@??$$";
            //string mensagem = null;
            //mensagem = texto;
            #endregion

            #region Tipo Implicíto Var
            //var valor = 140;
            //valor = 20;
            //valor = 49587664;
            #endregion

            #region Tipo Object (Base para todos os tipos)
            //object obj = false;
            //obj = 200;
            //obj = "Gabriel";
            #endregion

            #region Constante
            //const double pi = 3.1415;
            #endregion

            #region Enumeração
            //Notas notasAlunos = Notas.Media;
            #endregion

            Pessoa p1 = new Pessoa();

            p1.altura = 1.45;
            p1.idade = 45;
            p1.nome = "Eduardo";

            Pessoa p2 = new Pessoa()
            {
                nome = "Lucas",
                idade = 9,
                altura = 1.56
            };

            p1.nome = "Eduardo";




            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);

            Console.WriteLine();


            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);


            Console.ReadKey();
        }
    }
}
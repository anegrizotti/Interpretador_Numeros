using System;
using System.IO;

namespace Interpretador_Numeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeros = " __  __  __  __  __      __  __     \n" +
                             "|__ |__    ||__||__|  |  __| __||__|\n" +
                             " __||__|   ||__| __|  | |__  __|   |\n" +
                             "                                    \n" +
                             " __      __  __      __  __  __  __ \n" +
                             " __||__|   ||__|  |  __||__ |__ |__|\n" +
                             " __|   |   ||__|  | |__  __||__| __|\n" +
                             "                                    \n" +
                             " __  __  __  __  __      __  __     \n" +
                             " __| __||__ |__ |__||__|   ||__|  | \n" +
                             " __||__  __||__| __|   |   ||__|  | \n" +
                             "                                    \n" +
                             " __  __  __  __  __  __      __     \n" +
                             "|__| __||__ |__    ||__|  | |__||__|\n" +
                             "|__||__  __||__|   ||__|  |  __|   |\n" +
                             "                                    ";


            // declaração das variáveis de apoio
            int[] numeroResultado = new int[9];
            string[] primeiraLinha = new string[4];
            string[] segundaLinha = new string[4];
            string[] terceiraLinha = new string[4];
            string[] quartaLinha = new string[4];
            string[] substringPrimeiraLinha = new string[10];
            string[] substringSegundaLinha = new string[10];
            string[] substringTerceiraLinha = new string[10];
            int contX;
            int contY;

            StringReader leitor = new StringReader(numeros);

            for (int i = 0; i < 4; i++)
            {
                contX = 0;
                contY = 4;

                LeLinhaSDaSequencia(primeiraLinha, segundaLinha, terceiraLinha, quartaLinha, leitor, i);

                for (int j = 0; j < 9; j++)
                {
                    ObtemSubstringDeCadaLinha(primeiraLinha, segundaLinha, terceiraLinha, substringPrimeiraLinha, substringSegundaLinha, substringTerceiraLinha, contX, contY, i, j);

                    ComparaDesenhoComNumero(numeroResultado, substringPrimeiraLinha, substringSegundaLinha, substringTerceiraLinha, j);

                    contX = contX + 4;

                }

                ApresentaResultadoEmNumeros(numeroResultado);

                Console.WriteLine();

            }

        }

        #region métodos utilizados
        private static void ObtemSubstringDeCadaLinha(string[] primeiraLinha, string[] segundaLinha, string[] terceiraLinha, string[] substringPrimeiraLinha, string[] substringSegundaLinha, string[] substringTerceiraLinha, int contX, int contY, int i, int j)
        {
            substringPrimeiraLinha[j] = primeiraLinha[i].Substring(contX, contY);
            substringSegundaLinha[j] = segundaLinha[i].Substring(contX, contY);
            substringTerceiraLinha[j] = terceiraLinha[i].Substring(contX, contY);
        }

        private static void LeLinhaSDaSequencia(string[] primeiraLinha, string[] segundaLinha, string[] terceiraLinha, string[] quartaLinha, StringReader leitor, int i)
        {
            primeiraLinha[i] = leitor.ReadLine();
            segundaLinha[i] = leitor.ReadLine();
            terceiraLinha[i] = leitor.ReadLine();
            quartaLinha[i] = leitor.ReadLine();
        }

        private static void ApresentaResultadoEmNumeros(int[] numeroResultado)
        {
            for (int k = 0; k < 9; k++)
            {
                Console.Write(numeroResultado[k]);
            }
        }

        private static void ComparaDesenhoComNumero(int[] numeroResultado, string[] substringPrimeiraLinha, string[] substringSegundaLinha, string[] substringTerceiraLinha, int j)
        {
            if (substringPrimeiraLinha[j] == "    " && substringSegundaLinha[j] == "  | " && substringTerceiraLinha[j] == "  | ")
            {
                numeroResultado[j] = 1;

            }

            else if (substringPrimeiraLinha[j] == " __ " && substringSegundaLinha[j] == " __|" && substringTerceiraLinha[j] == "|__ ")
            {
                numeroResultado[j] = 2;
            }

            else if (substringPrimeiraLinha[j] == " __ " && substringSegundaLinha[j] == " __|" && substringTerceiraLinha[j] == " __|")
            {
                numeroResultado[j] = 3;
            }

            else if (substringPrimeiraLinha[j] == "    " && substringSegundaLinha[j] == "|__|" && substringTerceiraLinha[j] == "   |")
            {
                numeroResultado[j] = 4;
            }

            else if (substringPrimeiraLinha[j] == " __ " && substringSegundaLinha[j] == "|__ " && substringTerceiraLinha[j] == " __|")
            {
                numeroResultado[j] = 5;
            }

            else if (substringPrimeiraLinha[j] == (" __ ") && substringSegundaLinha[j] == "|__ " && substringTerceiraLinha[j] == "|__|")
            {
                numeroResultado[j] = 6;
            }

            else if (substringPrimeiraLinha[j] == " __ " && substringSegundaLinha[j] == "   |" && substringTerceiraLinha[j] == "   |")
            {
                numeroResultado[j] = 7;
            }

            else if (substringPrimeiraLinha[j] == " __ " && substringSegundaLinha[j] == "|__|" && substringTerceiraLinha[j] == "|__|")
            {
                numeroResultado[j] = 8;
            }

            else if (substringPrimeiraLinha[j] == " __ " && substringSegundaLinha[j] == "|__|" && substringTerceiraLinha[j] == " __|")
            {
                numeroResultado[j] = 9;
            }

            else if (substringPrimeiraLinha[j] == " __ " && substringSegundaLinha[j] == "|  |" && substringTerceiraLinha[j] == "|__|")
            {
                numeroResultado[j] = 0;
            }
        }

        #endregion

    }
}

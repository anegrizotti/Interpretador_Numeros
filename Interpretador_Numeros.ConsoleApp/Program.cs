using System;

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

            System.IO.StringReader leitor = new System.IO.StringReader(numeros);

            for (int j = 0; j < 4; j++)
            {
                contX = 0;
                contY = 4;
                primeiraLinha[j] = leitor.ReadLine();
                segundaLinha[j] = leitor.ReadLine();
                terceiraLinha[j] = leitor.ReadLine();
                quartaLinha[j] = leitor.ReadLine();

                for (int i = 0; i < 9; i++)
                {

                    substringPrimeiraLinha[i] = primeiraLinha[j].Substring(contX, contY);
                    substringSegundaLinha[i] = segundaLinha[j].Substring(contX, contY);
                    substringTerceiraLinha[i] = terceiraLinha[j].Substring(contX, contY);

                    if (substringPrimeiraLinha[i] == "    " && substringSegundaLinha[i] == "  | " && substringTerceiraLinha[i] == "  | ")
                    {
                        numeroResultado[i] = 1;

                    }

                    else if (substringPrimeiraLinha[i] == " __ " && substringSegundaLinha[i] == " __|" && substringTerceiraLinha[i] == "|__ ")
                    {
                        numeroResultado[i] = 2;
                    }

                    else if (substringPrimeiraLinha[i] == " __ " && substringSegundaLinha[i] == " __|" && substringTerceiraLinha[i] == " __|")
                    {
                        numeroResultado[i] = 3;
                    }

                    else if (substringPrimeiraLinha[i] == "    " && substringSegundaLinha[i] == "|__|" && substringTerceiraLinha[i] == "   |")
                    {
                        numeroResultado[i] = 4;
                    }

                    else if (substringPrimeiraLinha[i] == " __ " && substringSegundaLinha[i] == "|__ " && substringTerceiraLinha[i] == " __|")
                    {
                        numeroResultado[i] = 5;
                    }

                    else if (substringPrimeiraLinha[i] == (" __ ") && substringSegundaLinha[i] == "|__ " && substringTerceiraLinha[i] == "|__|")
                    {
                        numeroResultado[i] = 6;
                    }

                    else if (substringPrimeiraLinha[i] == " __ " && substringSegundaLinha[i] == "   |" && substringTerceiraLinha[i] == "   |")
                    {
                        numeroResultado[i] = 7;
                    }

                    else if (substringPrimeiraLinha[i] == " __ " && substringSegundaLinha[i] == "|__|" && substringTerceiraLinha[i] == "|__|")
                    {
                        numeroResultado[i] = 8;
                    }

                    else if (substringPrimeiraLinha[i] == " __ " && substringSegundaLinha[i] == "|__|" && substringTerceiraLinha[i] == " __|")
                    {
                        numeroResultado[i] = 9;
                    }

                    else if (substringPrimeiraLinha[i] == " __ " && substringSegundaLinha[i] == "|  |" && substringTerceiraLinha[i] == "|__|")
                    {
                        numeroResultado[i] = 0;
                    }

                    contX = contX + 4;

                }

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(numeroResultado[i]);
                }

                Console.WriteLine();

            }

        }   
    }
}

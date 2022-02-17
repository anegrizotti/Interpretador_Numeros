using System;

namespace Interpretador_Numeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numeros = "     __  __      __  __  __  __  __  __ \n" +
                             "  |  __| __||__||__ |__    ||__||__||  |\n" +
                             "  | |__  __|   | __||__|   ||__| __||__|\n";

            int[] numeroResultado = new int[10];
            string[] substringPrimeiraLinha = new string[10];
            string[] substringSegundaLinha = new string[10];
            string[] substringTerceiraLinha = new string[10];
            int contX = 0;
            int contY = 4;

            System.IO.StringReader leitor = new System.IO.StringReader(numeros);

            string primeiraLinha = leitor.ReadLine();

            string segundaLinha = leitor.ReadLine();

            string terceiraLinha = leitor.ReadLine();

            for (int i = 0; i < 10; i++) {

                substringPrimeiraLinha[i] = primeiraLinha.Substring(contX, contY);
                substringSegundaLinha[i] = segundaLinha.Substring(contX, contY);
                substringTerceiraLinha[i] = terceiraLinha.Substring(contX, contY);

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

            for (int i = 0; i < 10; i++)
            {
                Console.Write(numeroResultado[i]);
            }

        }   
    }
}

﻿namespace DiamanteDeX.ConsoleApp
{
    internal class Functions
    {
        public static int ValidarNumeroImpar(int numeroDigitado)
        {
            bool numeroImpar = numeroDigitado % 2 == 0;

            while (numeroImpar)
            {
                Console.Write("O numero digitado é invalido! digite um numero ÍMPAR: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
                numeroImpar = numeroDigitado % 2 == 0;
            }
            return numeroDigitado;
        }


        public static int NumeroEhPositivo(int numeroDigitado)
        {
            bool numeroEhPositivo = numeroDigitado < 0;

            while (numeroEhPositivo)
            {
                Console.Write("Numero Invalido! Digite um numero Ímpar Positivo: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
            }

            return numeroDigitado;
        }

        public static void ApresentarDiamante(int numeroDigitado)
        {
            int espacoEmBranco = numeroDigitado / 2;
            int escreverX = 1;
            for (int i = 0; i < numeroDigitado; i++)
            {
                for (int j = 0; j < espacoEmBranco; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < escreverX; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
                if (i < numeroDigitado / 2)
                {
                    espacoEmBranco--;
                    escreverX += 2;
                }
                else
                {
                    espacoEmBranco++;
                    escreverX -= 2;
                }
            }
        }
    }
}

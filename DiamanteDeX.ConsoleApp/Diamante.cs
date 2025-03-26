namespace DiamanteDeX.ConsoleApp
{
    internal class Diamante
    {
        public static int numeroDigitado;
        public static int LerNumero()
        {
            Console.Write("Digite um número ímpar Positivo: ");
            numeroDigitado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            return numeroDigitado;
        }

        public static int ValidarNumeroImpar()
        {
            bool numeroImpar = numeroDigitado % 2 == 0;

            while (numeroImpar)
            {
                Console.Write("Numero Inválido! digite um numero ÍMPAR: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
                numeroImpar = numeroDigitado % 2 == 0;
                Console.Clear();

                StringsDeSistema.ExibirCabecalho();
            }
            return numeroDigitado;
        }

        public static int NumeroEhPositivo()
        {
            bool numeroEhPositivo = true;
            if (numeroDigitado > 0)
                numeroEhPositivo = false;

            while (numeroEhPositivo)
            {
                Console.Write("Numero Invalido! Digite um numero Ímpar Positivo: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                StringsDeSistema.ExibirCabecalho();

                if (numeroDigitado > 0)
                    break;
            }
            return numeroDigitado;
        }

        public static void ApresentarDiamante()
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

            Console.WriteLine();
        }

    }
}

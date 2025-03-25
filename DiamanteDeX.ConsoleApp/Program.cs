namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        // 1° Fase do Projeto.
        //Permitir ao usuário digitar um numero impar como entrada de dados.
        //Fazer a Validação da especificação do numero: (Aceitar somente números impares)
        //Caso a entrada dada pelo usuário não atenda a especificação do ponto 2, solicitar nova entrada antes de prosseguir.


        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("----- Diamante de X -----");
            Console.WriteLine("-------------------------\n");

            Console.Write("Digite um número ímpar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            Functions.ValidarNumeroImpar(numeroDigitado);

            ApresentarDiamante(numeroDigitado);

            Console.ReadLine();
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

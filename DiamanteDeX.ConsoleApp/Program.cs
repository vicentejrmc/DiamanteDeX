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

            Console.WriteLine("Digite um número ímpar: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            ValidarNumeroImpar(numeroDigitado);



            Console.ReadLine();
        }

        public static int ValidarNumeroImpar(int numeroDigitado)
        {
            bool numeroImpar = numeroDigitado % 2 == 0;

            while (numeroImpar)
            {
                Console.WriteLine("O numero digitado é invalido! digite um numero ÍMPAR: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
                numeroImpar = numeroDigitado % 2 == 0;
            }
            return numeroDigitado;
        }
    }
}

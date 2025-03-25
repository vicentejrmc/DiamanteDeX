namespace DiamanteDeX.ConsoleApp
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

    }
}

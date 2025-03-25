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

            Functions.NumeroEhPositivo(numeroDigitado);

            Functions.ValidarNumeroImpar(numeroDigitado);

            Functions.ApresentarDiamante(numeroDigitado);

            Console.ReadLine();
        }

        
       

    }
}

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
            while (true)
            {
                ExibirCabecalho();

                Console.Write("Digite um número ímpar: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                numeroDigitado = Functions.NumeroEhPositivo(numeroDigitado);

                numeroDigitado = Functions.ValidarNumeroImpar(numeroDigitado);

                Functions.ApresentarDiamante(numeroDigitado);

                Console.Write("Deseja Tentar um novo Diamante? S/N: ");
                string TentarUmNovo = Console.ReadLine().ToUpper();

                if (TentarUmNovo != "S")
                    break;
            }


           
        }     
        public static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("----- Diamante de X -----");
            Console.WriteLine("-------------------------\n");
        }

    }
}

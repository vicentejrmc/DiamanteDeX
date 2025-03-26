namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        public static int numeroDigitado;
        static void Main(string[] args)
        {

            while (true)
            {
                Functions.ExibirCabecalho();

                numeroDigitado = Functions.LerNumero();
                Console.WriteLine();

                bool numeroValido = false;
                while (numeroValido == false)
                {                 
                    numeroDigitado = Functions.NumeroEhPositivo();

                    numeroDigitado = Functions.ValidarNumeroImpar();

                    if(numeroDigitado % 2 != 0 && numeroDigitado > 0)
                        numeroValido = true;
                }

            Functions.ApresentarDiamante();

            Console.Write("Deseja Tentar um novo Diamante? S/N: ");
            string TentarUmNovo = Console.ReadLine()!.ToUpper();

            if (TentarUmNovo != "S")
                break;
            }

            Functions.MensagemFinal();
        }
    }
}

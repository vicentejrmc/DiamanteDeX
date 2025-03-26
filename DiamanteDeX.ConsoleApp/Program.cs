namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        public static int numeroDigitado;
        static void Main(string[] args)
        {
            while (true)
            {
                StringsDeSistema.ExibirCabecalho();

                numeroDigitado = Diamante.LerNumero();

                while (true)
                {
                    numeroDigitado = Diamante.NumeroEhPositivo();

                    numeroDigitado = Diamante.NumeroEhImpar();

                    if (numeroDigitado % 2 != 0 && numeroDigitado > 0)
                        break;
                }

                StringsDeSistema.MensagemDiamante(numeroDigitado);

                Diamante.ApresentarDiamante();

                Console.Write("Deseja Tentar um novo Diamante? S/N: ");
                string TentarUmNovo = Console.ReadLine()!.ToUpper();

                if (TentarUmNovo != "S")
                    break;
            }

            StringsDeSistema.MensagemFinal();
        }
    }
}

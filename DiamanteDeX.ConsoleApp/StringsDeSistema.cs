
namespace DiamanteDeX.ConsoleApp
{
    internal class StringsDeSistema
    {
        public static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("----- Diamante de X -----");
            Console.WriteLine("-------------------------\n");
        }
        public static void MensagemDiamante(int numeroDigitado)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Você está vendo o Diamante de X do numero: {numeroDigitado}");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
        }
        public static void MensagemFinal()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Obrigado por utilizar o Diamante de X!");
            Console.Write("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }

    }
}

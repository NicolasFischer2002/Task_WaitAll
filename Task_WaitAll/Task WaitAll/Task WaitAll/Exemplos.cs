

namespace Task_WaitAll
{
    public class Exemplos
    {
        public static async Task EscreveCidades_async(string[] Cidades)
        {
            for (int i = 0; i < Cidades.Length; i++)
            {
                Console.WriteLine(Cidades[i]);
                await Task.Delay(1000);
            }
        }

        public static async Task EscrevePaises_async(string[] Paises)
        {
            for (int i = 0; i < Paises.Length; i++)
            {
                Console.WriteLine(Paises[i]);
                await Task.Delay(1000);
            }
        }
    }
}

using System;

namespace Exemplol2
{
    public class Program
    {
        static string[,] pessoas = new string[2, 3];
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Consultar");
                Console.WriteLine("4 - Alterar");
                Console.WriteLine("5 - Excluir");
                Console.WriteLine("I - Importar");
                Console.WriteLine("E - Exportar");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1': SolicitarInformacoes(); break;
                    case '2': ExibirInformacoes(); break;
                    case '3': Consultar(); break;
                }
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }
        static void SolicitarInformacoes()
        {
            Console.Clear();
            // Solicitando as informações das pessoas ...
            for (int i = 0; i < pessoas.GetLength(0); i++)
            {
                Console.Write($"Informe o nome da pessoa {i + 1}: ");
                pessoas[i, 0] = Console.ReadLine();
                Console.Write($"Informe a idade da pessoa {i + 1}: ");
                pessoas[i, 1] = Console.ReadLine();
                Console.Write($"Informe o e-mail da pessoa {i + 1}: ");
                pessoas[i, 2] = Console.ReadLine();
            }
        }
        static void ExibirInformacoes()
        {
            Console.Clear();
            // Exibindo as informações das pessoas ...
            for (int j = 0; j < pessoas.GetLength(0); j++)
            {
                if (pessoas[j, 0] != null && pessoas[j, 0] != "")
                    Console.WriteLine($"{pessoas[j, 0]} {pessoas[j, 1]} - {pessoas[j, 2]}");
            }
        }
        static void Consultar()
        {
            Console.Clear();
            Console.WriteLine("Qual é o nome da pessoa que você deseja consultar: ");
            string nomeProcurado = Console.ReadLine();
            // Exibindo as informações das pessoas ...
            for (int j = 0; j < pessoas.GetLength(0); j++)
            {
                if (pessoas[j, 0].ToLower() == nomeProcurado.ToLower())
                    Console.WriteLine($"{pessoas[j, 0]} {pessoas[j, 1]} - {pessoas[j, 2]}");
            }
        }
    }
}
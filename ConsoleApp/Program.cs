using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static List<ClienteModel> clientes = new List<ClienteModel>();
        enum CaseSensitive { Maiuscula, Minuscula, NaoSensitivo }
        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            int numlcientes = clientes.Count;
            Console.Clear();
            Console.WriteLine(string.Format("Cadastro de clientes: {0} clientes cadastrados\n", numlcientes));
            Console.WriteLine("I - Incluir cliente");
            Console.WriteLine("A - Alterar cliente");
            Console.WriteLine("E - Exlcuir cliente");
            Console.WriteLine("L - Listar todos os clientes");
            Console.WriteLine("P - Procurar cliente");
            Console.WriteLine("\n\nSelecione a opcao desejada ou pressione ESC para sair");
            ConsoleKeyInfo cki = Console.ReadKey();
            switch (cki.Key)
            {
                case ConsoleKey.I: Incluir(); break;
                case ConsoleKey.A: Alterar(); break;
                case ConsoleKey.E: Excluir(); break;
                case ConsoleKey.L: Listar(null); break;
                case ConsoleKey.P: Procurar(); break;
                case ConsoleKey.Escape: return;
                default: MenuPrincipal(); break;
            }

        }

        static void Incluir()
        {
            ClienteModel cliente = new ClienteModel();
            Console.Clear();
            Console.WriteLine("Incluir cliente\n");
            Console.WriteLine("ID................: ");
            Console.WriteLine("Nome..............: ");
            Console.WriteLine("Endereco..........: ");
            Console.WriteLine("Bairro............: ");
            Console.WriteLine("Cidade............: ");
            Console.WriteLine("Estado............: ");
            Console.WriteLine("CEP...............: ");
            Console.WriteLine("CPF...............: ");
            Console.WriteLine("Data de nascimento: ");
            Console.WriteLine("Telefone..........: ");
            Console.WriteLine("email.............: ");

            //ID
            Console.SetCursorPosition(20, 2);
            cliente.ID = clientes.Count + 1;
            Console.Write(cliente.ID);

            //Nome
            Console.SetCursorPosition(20, 3);
            cliente.Nome = lerTexto(50, CaseSensitive.Maiuscula, string.Empty);

            //Endereco
            Console.SetCursorPosition(20, 4);
            cliente.Endereco = lerTexto(50, CaseSensitive.Maiuscula, string.Empty);

            //Bairro
            Console.SetCursorPosition(20, 5);
            cliente.Bairro = lerTexto(50, CaseSensitive.Maiuscula, string.Empty);

            //Cidade
            Console.SetCursorPosition(20, 6);
            cliente.Cidade = lerTexto(50, CaseSensitive.Maiuscula, string.Empty);

            //Estado
            Console.SetCursorPosition(20, 7);
            cliente.Estado = lerTexto(2, CaseSensitive.Maiuscula, string.Empty);

            //CEP
            Console.SetCursorPosition(20, 8);
            cliente.CEP = lerNumero(8, string.Empty);

            //CPF
            Console.SetCursorPosition(20, 9);
            cliente.CPF = lerNumero(11, string.Empty);

            //Data de nascimento
            Console.SetCursorPosition(20, 10);
            cliente.DataNascimento = lerData(string.Empty);

            //Telefone
            Console.SetCursorPosition(20, 11);
            cliente.Telefone = lerNumero(10, string.Empty);

            //email
            Console.SetCursorPosition(20, 12);
            cliente.eMail = lerTexto(50, CaseSensitive.Minuscula, string.Empty);

            Console.SetCursorPosition(0, 14);
            Console.Write("Confirma inclusao do cliente? (S/N)");
            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                clientes.Add(cliente);
                Console.SetCursorPosition(0, 16);
                Console.WriteLine("Cliente incluido com sucesso. Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.SetCursorPosition(0, 16);
                Console.WriteLine("Inclusao cancelada. Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            MenuPrincipal();
        }

        static void Alterar()
        {
            ClienteModel cliente = new ClienteModel();
            Console.Clear();
            Console.WriteLine("Alterar cliente\n");
            Console.WriteLine("ID................: ");
            Console.WriteLine("Nome..............: ");
            Console.WriteLine("Endereco..........: ");
            Console.WriteLine("Bairro............: ");
            Console.WriteLine("Cidade............: ");
            Console.WriteLine("Estado............: ");
            Console.WriteLine("CEP...............: ");
            Console.WriteLine("CPF...............: ");
            Console.WriteLine("Data de nascimento: ");
            Console.WriteLine("Telefone..........: ");
            Console.WriteLine("email.............: ");

            Console.SetCursorPosition(20, 2);
            int id = int.Parse(lerNumero(10, string.Empty));
            cliente = clientes.Where(c => c.ID == id).FirstOrDefault();
            if (cliente != null)
            {
                //ID
                Console.SetCursorPosition(20, 2);
                Console.Write(cliente.ID);

                //Nome
                Console.SetCursorPosition(20, 3);
                Console.Write(cliente.Nome);
                cliente.Nome = lerTexto(50, CaseSensitive.Maiuscula, cliente.Nome);

                //Endereco
                Console.SetCursorPosition(20, 4);
                Console.Write(cliente.Endereco);
                cliente.Endereco = lerTexto(50, CaseSensitive.Maiuscula, cliente.Endereco);

                //Bairro
                Console.SetCursorPosition(20, 5);
                Console.Write(cliente.Bairro);
                cliente.Bairro = lerTexto(50, CaseSensitive.Maiuscula, cliente.Bairro);

                //Cidade
                Console.SetCursorPosition(20, 6);
                Console.Write(cliente.Cidade);
                cliente.Cidade = lerTexto(50, CaseSensitive.Maiuscula, cliente.Cidade);

                //Estado
                Console.SetCursorPosition(20, 7);
                Console.Write(cliente.Estado);
                cliente.Estado = lerTexto(2, CaseSensitive.Maiuscula, cliente.Estado);

                //CEP
                Console.SetCursorPosition(20, 8);
                Console.Write(cliente.CEP);
                cliente.CEP = lerNumero(8, cliente.CEP);

                //CPF
                Console.SetCursorPosition(20, 9);
                Console.Write(cliente.CPF);
                cliente.CPF = lerNumero(11, cliente.CPF);

                //Data de nascimento
                Console.SetCursorPosition(20, 10);
                Console.Write(cliente.DataNascimento.ToString("ddMMyyyy"));
                cliente.DataNascimento = lerData(cliente.DataNascimento.ToString("ddMMyyyy"));

                //Telefone
                Console.SetCursorPosition(20, 11);
                Console.Write(cliente.Telefone);
                cliente.Telefone = lerNumero(10, cliente.Telefone);

                //email
                Console.SetCursorPosition(20, 12);
                Console.Write(cliente.eMail);
                cliente.eMail = lerTexto(50, CaseSensitive.Minuscula, cliente.eMail);

                Console.SetCursorPosition(0, 14);
                Console.Write("Confirma alteracao do cliente? (S/N)");
                if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    clientes.Remove(cliente);
                    clientes.Add(cliente);
                    Console.SetCursorPosition(0, 16);
                    Console.WriteLine("Cliente alterado com sucesso. Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.SetCursorPosition(0, 16);
                    Console.WriteLine("alteracao cancelada. Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.SetCursorPosition(0, 14);
                Console.WriteLine("Cliente nao encontrado. Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            MenuPrincipal();
        }

        static void Excluir()
        {
            ClienteModel cliente = new ClienteModel();
            Console.Clear();
            Console.WriteLine("Excluir cliente\n");
            Console.WriteLine("ID................: ");
            Console.WriteLine("Nome..............: ");
            Console.WriteLine("Endereco..........: ");
            Console.WriteLine("Bairro............: ");
            Console.WriteLine("Cidade............: ");
            Console.WriteLine("Estado............: ");
            Console.WriteLine("CEP...............: ");
            Console.WriteLine("CPF...............: ");
            Console.WriteLine("Data de nascimento: ");
            Console.WriteLine("Telefone..........: ");
            Console.WriteLine("email.............: ");

            Console.SetCursorPosition(20, 2);
            int id = int.Parse(lerNumero(10, string.Empty));
            cliente = clientes.Where(c => c.ID == id).FirstOrDefault();
            if (cliente != null)
            {
                //ID
                Console.SetCursorPosition(20, 2);
                Console.Write(cliente.ID);

                //Nome
                Console.SetCursorPosition(20, 3);
                Console.Write(cliente.Nome);

                //Endereco
                Console.SetCursorPosition(20, 4);
                Console.Write(cliente.Endereco);

                //Bairro
                Console.SetCursorPosition(20, 5);
                Console.Write(cliente.Bairro);

                //Cidade
                Console.SetCursorPosition(20, 6);
                Console.Write(cliente.Cidade);

                //Estado
                Console.SetCursorPosition(20, 7);
                Console.Write(cliente.Estado);

                //CEP
                Console.SetCursorPosition(20, 8);
                Console.Write(cliente.CEP);

                //CPF
                Console.SetCursorPosition(20, 9);
                Console.Write(cliente.CPF);

                //Data de nascimento
                Console.SetCursorPosition(20, 10);
                Console.Write(cliente.DataNascimento);

                //Telefone
                Console.SetCursorPosition(20, 11);
                Console.Write(cliente.Telefone);

                //email
                Console.SetCursorPosition(20, 12);
                Console.Write(cliente.eMail);

                Console.SetCursorPosition(0, 14);
                Console.Write("Confirma exclusao do cliente? (S/N)");
                if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    clientes.Remove(cliente);
                    Console.SetCursorPosition(0, 16);
                    Console.WriteLine("Cliente excluido com sucesso. Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.SetCursorPosition(0, 16);
                    Console.WriteLine("Exclusao cancelada. Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.SetCursorPosition(0, 14);
                Console.WriteLine("Cliente nao encontrado. Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            MenuPrincipal();
        }

        static void Listar(string argumento)
        {
            Console.Clear();
            List<ClienteModel> clientesEncontrados = clientes.Where(c => argumento == null ||
                                                                         c.ID.ToString().Contains(argumento) ||
                                                                         c.Nome.Contains(argumento) ||
                                                                         c.Endereco.Contains(argumento) ||
                                                                         c.Bairro.Contains(argumento) ||
                                                                         c.Cidade.Contains(argumento) ||
                                                                         c.Estado.Contains(argumento) ||
                                                                         c.CEP.Contains(argumento) ||
                                                                         c.CPF.Contains(argumento) ||
                                                                         //c.DataNascimento.Contains(argumento) ||
                                                                         c.Telefone.Contains(argumento) ||
                                                                         c.eMail.Contains(argumento)).ToList();
            if (clientesEncontrados.Count > 0)
            {
                foreach (ClienteModel cliente in clientesEncontrados)
                {
                    Console.WriteLine(string.Format("Cliente:{0} Nome={1} Endereco={2} Bairro={3} Cidade={4} Estado={5} CEP={6} CPF={7} Data de nascimento={8} Telefone={9} email={10}",
                                                     cliente.ID, cliente.Nome, cliente.Endereco, cliente.Bairro, cliente.Cidade, cliente.Estado, cliente.CEP, cliente.CPF, cliente.DataNascimento, cliente.Telefone, cliente.eMail));
                }
                Console.WriteLine("\nListagem concluida com sucesso. Pressione qualquer tecla para continuar...");
            }
            else
            {
                Console.WriteLine("Nao foram encontrados clientes. Pressione qualquer tecla para continuar...");
            }
            Console.ReadKey();
            MenuPrincipal();
        }

        static void Procurar()
        {
            Console.Clear();
            Console.WriteLine("Procurar cliente\n");
            Console.WriteLine("Texto de pesquisa.: ");

            Console.SetCursorPosition(20, 2);
            string argumento = lerTexto(50, CaseSensitive.NaoSensitivo, string.Empty);
            Listar(argumento);
        }

        static string lerTexto(int caracteres, CaseSensitive caseSensitive, string texto)
        {
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;
                if (key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (key == ConsoleKey.Escape)
                {
                    int tamanho = texto.Length;
                    for (int i = 1; i <= tamanho; i++)
                    {
                        Console.Write("\b \b");
                        texto = texto.Substring(0, texto.Length - 1);
                    }
                }
                else if (key == ConsoleKey.Backspace && texto.Length > 0)
                {
                    Console.Write("\b \b");
                    texto = texto.Substring(0, texto.Length - 1);
                }
                else if (!char.IsControl(keyInfo.KeyChar) && texto.Length < caracteres)
                {
                    char caractere = caseSensitive == CaseSensitive.Maiuscula ? Char.ToUpper(keyInfo.KeyChar) : caseSensitive == CaseSensitive.Minuscula ? Char.ToLower(keyInfo.KeyChar) : keyInfo.KeyChar; 
                    Console.Write(caractere);
                    texto += caractere;
                }

            } while (true);

            return texto;
        }

        static string lerNumero(int digitos, string texto)
        {
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;
                if (key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (key == ConsoleKey.Escape)
                {
                    int tamanho = texto.Length;
                    for (int i = 1; i <= tamanho; i++)
                    {
                        Console.Write("\b \b");
                        texto = texto.Substring(0, texto.Length - 1);
                    }
                }
                else if (key == ConsoleKey.Backspace && texto.Length > 0)
                {
                    Console.Write("\b \b");
                    texto = texto.Substring(0, texto.Length - 1);
                }
                else if (!char.IsControl(keyInfo.KeyChar) && char.IsNumber(keyInfo.KeyChar) && texto.Length < digitos)
                {
                    Console.Write(Char.ToUpper(keyInfo.KeyChar));
                    texto += Char.ToUpper(keyInfo.KeyChar);
                }

            } while (true);

            return texto;
        }

        static DateTime lerData(string texto)
        {
            DateTime data;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;
                if (key == ConsoleKey.Enter)
                {
                    try
                    {
                        if (texto != null && texto != "")
                            data = DateTime.ParseExact(texto, "ddMMyyyy", null);
                        else
                            data = DateTime.MinValue;
                        break;
                    }
                    catch
                    {

                    }
                }
                else if (key == ConsoleKey.Escape)
                {
                    int tamanho = texto.Length;
                    for (int i = 1; i <= tamanho; i++)
                    {
                        Console.Write("\b \b");
                        texto = texto.Substring(0, texto.Length - 1);
                    }
                }
                else if (key == ConsoleKey.Backspace && texto.Length > 0)
                {
                    Console.Write("\b \b");
                    texto = texto.Substring(0, texto.Length - 1);
                }
                else if (!char.IsControl(keyInfo.KeyChar) && char.IsNumber(keyInfo.KeyChar) && texto.Length < 8)
                {
                    Console.Write(Char.ToUpper(keyInfo.KeyChar));
                    texto += Char.ToUpper(keyInfo.KeyChar);
                }

            } while (true);
            return data;
        }
    }
}

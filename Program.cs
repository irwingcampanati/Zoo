using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listaDeAnimais = new List<Animal>();
            
            var caminhoPastaBancoDeDados = Directory.GetCurrentDirectory() + "\\BancoDeDados";
            var caminhoDoArquivo = caminhoPastaBancoDeDados + "\\PrimeiroBancoDeDados.txt";

            if (!Directory.Exists(caminhoPastaBancoDeDados))
                Directory.CreateDirectory(caminhoPastaBancoDeDados);

            if (!File.Exists(caminhoDoArquivo)) {

                using (FileStream fs = File.Create(caminhoDoArquivo))
                {
                }
            }

            Console.WriteLine("Bem vindo ao serviço de cadastro e consulta de animais do Zoológico, selecione abaixo a opção desejada e confirme.");
            Console.WriteLine("1 - Cadastrar novos animais.");
            Console.WriteLine("2 - Consultar animais já cadastrados no banco de dados.");
            Console.WriteLine("3 - Fazer backup do banco já cadastrado.");
            Console.WriteLine("4 - Apagar as informações já cadastradas no banco de dados.");
            Console.WriteLine("5 - Sair.");
            double opcao = double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    do
                    {
                        var animal = new Animal();
                        Console.WriteLine("Qual espécie de animal voce deseja cadastrar?");
                        var especie = Console.ReadLine();
                        if (especie == "Gato" | especie == "Cachorro" | especie == "Vaca")
                        {
                            if (especie == "Gato")
                            {
                                var gato = new Gato();
                                Console.Write("Nome: ");
                                gato.Nome = Console.ReadLine();
                                Console.Write("Data de nascimento: ");
                                gato.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                                Console.Write("Cor: ");
                                gato.Cor = Console.ReadLine();
                                Console.WriteLine(gato.Som);

                                listaDeAnimais.Add(gato);
                                File.AppendAllText(caminhoDoArquivo, gato.Nome + "; ");
                                File.AppendAllText(caminhoDoArquivo, gato.DataNascimento + "; ");
                                File.AppendAllText(caminhoDoArquivo, gato.Cor + "; ");
                                File.AppendAllText(caminhoDoArquivo, gato.Som + "; ");
                                File.AppendAllText(caminhoDoArquivo, "\n");
                            }

                            if (especie == "Cachorro")
                            {
                                var cachorro = new Cachorro();
                                Console.Write("Nome: ");
                                cachorro.Nome = Console.ReadLine();                                
                                Console.Write("Data de nascimento: ");
                                cachorro.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                                Console.Write("Cor: ");
                                cachorro.Cor = Console.ReadLine();
                                Console.WriteLine(cachorro.Som);

                                listaDeAnimais.Add(cachorro);
                                File.AppendAllText(caminhoDoArquivo, cachorro.Nome + "; ");
                                File.AppendAllText(caminhoDoArquivo, cachorro.DataNascimento + "; ");
                                File.AppendAllText(caminhoDoArquivo, cachorro.Cor + "; ");
                                File.AppendAllText(caminhoDoArquivo, cachorro.Som + "; ");
                                File.AppendAllText(caminhoDoArquivo, cachorro.TemMancha + "; ");
                                File.AppendAllText(caminhoDoArquivo, "\n");
                            }

                            if (especie == "Vaca")
                            {
                                var vaca = new Vaca();
                                Console.Write("Nome: ");
                                vaca.Nome = Console.ReadLine();
                                Console.Write("Data de nascimento: ");
                                vaca.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                                Console.Write("Cor: ");
                                vaca.Cor = Console.ReadLine();
                                Console.WriteLine(vaca.Som);

                                listaDeAnimais.Add(vaca);
                                File.AppendAllText(caminhoDoArquivo, vaca.Nome + "; ");
                                File.AppendAllText(caminhoDoArquivo, vaca.DataNascimento + "; ");
                                File.AppendAllText(caminhoDoArquivo, vaca.Cor + "; ");
                                File.AppendAllText(caminhoDoArquivo, vaca.Som + "; ");
                                File.AppendAllText(caminhoDoArquivo, vaca.EstaDoente + "; ");
                                File.AppendAllText(caminhoDoArquivo, "\n");
                            }

                            Console.WriteLine("Tecle ENTER para cadastrar novo animal. ESC para sair.");
                        }
                        else
                        {
                            Console.WriteLine("Voce digitou um animal inválido! Tecle ENTER e tente novamente");
                        }
                    }
                    while (Console.ReadKey().Key != ConsoleKey.Escape); // Preciso de uma opção pra fazer voltar pro menu ao invez de sair da aplicação //
                    break;

                case 2:
                    var dadosBancoDeDados = File.ReadAllText(caminhoDoArquivo);
                    Console.WriteLine(dadosBancoDeDados);
                    break;

                case 3:
                    File.Copy(caminhoDoArquivo, caminhoPastaBancoDeDados + "\\" + "Backup.txt", true);
                    break;
                
                case 4:
                    Directory.Delete(caminhoPastaBancoDeDados, true);
                    break;

                default:
                    break;
            }
        }
    }
}
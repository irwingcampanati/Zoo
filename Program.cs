namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listaDeAnimais = new List<Animal>();
            var caminhoDoArquivo = "C:\\Users\\irwin\\OneDrive\\Documentos\\GitHub\\Zoo\\PrimeiroBancoDeDados.csv";

            Console.Clear();

            Console.WriteLine("Bem vindo ao serviço de cadastro e consulta de animais do Zoológico, selecione abaixo a opção desejada e confirme.");
            Console.WriteLine("1 - Cadastrar novos animais.");
            Console.WriteLine("2 - Consultar animais já cadastrados no banco de dados.");
            Console.WriteLine("3 - Apagar as informações já cadastradas e cadastrar novo banco de dados.");
            Console.WriteLine("4 - Sair.");
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
                                // Descobrir porque não está saindo o Som do animal //

                                var gato = new Gato();
                                Console.Write("Nome: ");
                                gato.Nome = Console.ReadLine();
                                Console.Write("Data de nascimento: ");
                                gato.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                                Console.Write("Cor: ");
                                gato.Cor = Console.ReadLine();
                                Console.WriteLine(gato.Som);
                                listaDeAnimais.Add(gato);
                                File.AppendAllText(caminhoDoArquivo, gato.Nome + ";");
                                File.AppendAllText(caminhoDoArquivo, gato.DataNascimento + ";");
                                File.AppendAllText(caminhoDoArquivo, gato.Cor + ";");
                                File.AppendAllText(caminhoDoArquivo, gato.Som + ";");
                                File.AppendAllText(caminhoDoArquivo, "\n");
                            }

                            if (especie == "Cachorro")
                            {
                                // Descobrir porque não está saindo o Som do animal e nem a caracteristica booleana //

                                var cachorro = new Cachorro();
                                Console.Write("Nome: ");
                                cachorro.Nome = Console.ReadLine();
                                Console.Write("Data de nascimento: ");
                                cachorro.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                                Console.Write("Cor: ");
                                cachorro.Cor = Console.ReadLine();                           
                                listaDeAnimais.Add(cachorro);
                                File.AppendAllText(caminhoDoArquivo, cachorro.Nome + ";");
                                File.AppendAllText(caminhoDoArquivo, cachorro.DataNascimento + ";");
                                File.AppendAllText(caminhoDoArquivo, cachorro.Cor + ";");
                                File.AppendAllText(caminhoDoArquivo, cachorro.Som + ";");
                                File.AppendAllText(caminhoDoArquivo, "\n");
                            }

                            if (especie == "Vaca")
                            {
                                // Descobrir porque não está saindo o Som do animal e nem a caracteristica booleana //
                                
                                var vaca = new Vaca();
                                Console.Write("Nome: ");
                                vaca.Nome = Console.ReadLine();
                                Console.Write("Data de nascimento: ");
                                vaca.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                                Console.Write("Cor: ");
                                vaca.Cor = Console.ReadLine();                                
                                listaDeAnimais.Add(vaca);
                                File.AppendAllText(caminhoDoArquivo, vaca.Nome + ";");
                                File.AppendAllText(caminhoDoArquivo, vaca.DataNascimento + ";");
                                File.AppendAllText(caminhoDoArquivo, vaca.Cor + ";");
                                File.AppendAllText(caminhoDoArquivo, vaca.Som + ";");
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
                case 2: var dadosBancoDeDados = File.ReadAllText(caminhoDoArquivo); // Aprender a acessar/abrir o banco de dados //
                    break;
                case 3: // Aprender a fazer uma cópia do banco de dados existente, resetar/apagar e iniciar um novo //
                    break;
                default:
                    break;
            }


        }
    }
}
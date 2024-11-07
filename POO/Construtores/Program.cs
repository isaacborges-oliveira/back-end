// using Construtores.Classes;

// Veiculos carro1 = new Veiculos ("Ford","ka", 2000, "preto");
// Veiculos carro2 = new Veiculos ("Ford", "mustang", 2017, "preto");

// carro1.Exibirdados();

// carro2.Exibirdados();
// Console.WriteLine($"");
// List<jogos> estoquejogos = new List<jogos>();
// Console.WriteLine($"************Jogos************");

// Console.WriteLine($"");

// jogos jogo1 = new jogos ("shadow of the colossus", 2005, "aventura", 59 );
// jogos jogo2 = new jogos ("call of duty Black ops 6", 2024, "tiro porrada ee bomba", 390 );
// jogos jogo3 = new jogos ("resident evil 4 ", 2005, "tiro porrada ee bomba", 99);
// jogos jogo4 = new jogos ("", 2024, "tiro porrada ee bomba", 390 );

// estoquejogos.Add(jogo1);
// estoquejogos.Add(jogo2);
// estoquejogos.Add(jogo3);
// estoquejogos.Add(jogo4);

// foreach(var jogo in estoquejogos){
//     Console.WriteLine($"jogo: {jogo.nome}");
//     Console.WriteLine($"ano: {jogo.lancamento}");
//     Console.WriteLine($"genero: {jogo.genero}");
//     Console.WriteLine($"genero: {jogo.preco}");
//     Console.WriteLine($"");
    
// }

// Console.WriteLine($"");

// Console.WriteLine($"************Alunos************");

// Console.WriteLine($"");

// Alunos aluno1 = new Alunos ("roberval", 15, 5934400 );
// Alunos aluno2 = new Alunos ("jailson", 17, 51233440 );
// aluno1.Exibirdados();
// aluno2.Exibirdados();

// Program.cs

// Program.cs
// Program.cs

namespace CadastroDeJogos
{
    public class Program
    {
        private List<Jogo> jogos;

        public Program()
        {
            jogos = new List<Jogo>();
            Iniciar(); 
        }

        public void Iniciar()
        {
            while (true)
            {
                Console.WriteLine("1. Cadastrar Jogo");
                Console.WriteLine("2. Listar Jogos Cadastrados");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
      
                    Console.Write("Nome do Jogo: ");
                    string nome = Console.ReadLine();

                    Console.Write("Ano de Lançamento: ");
                    int anoLancamento = int.Parse(Console.ReadLine());

                    Console.Write("Gênero do Jogo: ");
                    string genero = Console.ReadLine();

                    Console.Write("Preço do Jogo: R$ ");
                    decimal preco = decimal.Parse(Console.ReadLine());

                    Jogo novoJogo = new Jogo(nome, anoLancamento, genero, preco);
                    jogos.Add(novoJogo);

                    Console.WriteLine("Jogo cadastrado com sucesso!\n");
                }
                else if (opcao == "2")
                {
                    // Listar Jogos
                    Console.WriteLine("\n--- Jogos Cadastrados ---");
                    if (jogos.Count == 0)
                    {
                        Console.WriteLine("Nenhum jogo cadastrado.");
                    }
                    else
                    {
                        foreach (var jogo in jogos)
                        {
                            jogo.ExibirInformacoes();
                        }
                    }
                }
                else if (opcao == "3")
                {
                    // Sair do programa
                    Console.WriteLine("Saindo do programa...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
        }
    }
}

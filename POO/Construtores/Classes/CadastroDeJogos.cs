// Jogo.cs
namespace CadastroDeJogos
{
    public class Jogo
    {
        public string Nome { get; set; }
        public int AnoLancamento { get; set; }
        public string Genero { get; set; }
        public decimal Preco { get; set; }

        public Jogo(string nome, int anoLancamento, string genero, decimal preco)
        {
            Nome = nome;
            AnoLancamento = anoLancamento;
            Genero = genero;
            Preco = preco;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Ano de Lançamento: {AnoLancamento}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Preço: R$ {Preco:F2}");
            Console.WriteLine("-----------------------");
        }
    }
}

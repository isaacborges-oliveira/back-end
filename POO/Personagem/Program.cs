
using Personagem.classe;

Jogador jogador = new Jogador();


Console.Write("Digite o nome do seu personagem: ");
jogador.Nome = Console.ReadLine();

Console.Write("Digite a idade do seu personagem: ");
jogador.Idade = int.Parse(Console.ReadLine());

Console.Write("Informe o nome da armadura do personagem: ");
jogador.Armadura = Console.ReadLine();

Console.Write("Informe a I.A que o personagem utiliza: ");
jogador.InteligenciaArtificial = Console.ReadLine();

Console.WriteLine($"o que voce quer fazer:");

Console.WriteLine($@"Escolha uma ação:
1- Atacar
2- Defender
3- Restaurar Armadura
");
string resposta = Console.ReadLine()!;

if (resposta == "1")
{
    jogador.Atacar("atacar");
} else if (resposta == "2")
{
    jogador.Defender("defender");
} else if (resposta == "3")
{
    jogador.RestaurarArmadura("restaurar");
} else {
    Console.WriteLine($"Respota invalida, do it again");
}


Console.WriteLine($"{jogador.Nome},");
Console.WriteLine($"{jogador.Idade},");
Console.WriteLine($"{jogador.Armadura},");
Console.WriteLine($"{jogador.InteligenciaArtificial}");


jogador.Atacar(jogador.Nome);
jogador.RestaurarArmadura(jogador.Nome);
jogador.Defender(jogador.Nome);

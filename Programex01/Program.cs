int qtdHomem = 0;
int qtdMulher = 0;
int qtdGostamEsportes = 0;
int qdtnaogostamEsportes = 0;
int qtdEsportes =0;

Console.Write("Quantas pessoaas tem na mesa?): ");

int qdtentrevistados = int.Parse(Console.ReadLine()!);



for (int i = 1; i <= qdtentrevistados; i++)
{
    Console.WriteLine("Digite o sexo (H para homem, M para mulher): ");
    string sexo = Console.ReadLine()!;

    if (sexo == "f")
    {
        qtdMulher++;
    }
    else
    {
        qtdHomem++;
    }
 Console.Write("Você gosta de esportes? (S para sim, N para não): ");
    string gostaEsportes = Console.ReadLine()!;


    if (gostaEsportes == "S")
    {
        qtdGostamEsportes++;
    }
    else {
qdtnaogostamEsportes++;
}

}
float percentual = (100 / qdtentrevistados) * qtdEsportes;

   

Console.WriteLine($"\nResumo da pesquisa:");
Console.WriteLine($"Total de homens: {qtdHomem}");
Console.WriteLine($"Total de mulheres: {qtdMulher}");
Console.WriteLine($"Total de pessoas que gostam de esportes: {qtdGostamEsportes}");
Console.WriteLine($"Percentual de pessoas que gostam de esportes: {percentual} %");

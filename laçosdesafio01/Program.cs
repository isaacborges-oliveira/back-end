
 int totalFeminino = 0;
 int totalMasculino = 0;
int totalGostamEsportes = 0;
  int totalEntrevistados = 0;

  Console.Write("Quantas pessoas serão entrevistadas? ");
  int qtdPessoas = int.Parse(Console.ReadLine());






  for (int i = 0; i < qtdPessoas; i++)
  {
    Console.WriteLine($"Entrevistando a pessoa {i + 1}:");

   Console.Write("Digite o sexo da pessoa (M para masculino, F para feminino): ");
   string sexo = Console.ReadLine();

  Console.Write("Gostou do produto? (S para sim, N para não): ");
  string gostaEsporte = Console.ReadLine();

     if (sexo == "F")
    {
        totalFeminino++;
     }
      else if (sexo == "M")
            {
                totalMasculino++;
            }

            if (gostaEsporte == "S")
            {
                totalGostamEsportes++;
            }

            totalEntrevistados++;
        }

float percentualEsportes = (float)totalGostamEsportes / totalEntrevistados * 100;

 Console.WriteLine("\nResultados:");

 Console.WriteLine($"Quantidade de pessoas do sexo feminino: {totalFeminino}");

  Console.WriteLine($"Quantidade de pessoas do sexo masculino: {totalMasculino}");

Console.WriteLine($"Quantidade de pessoas que gostam de esportes: {totalGostamEsportes}");

 Console.WriteLine($"Total de entrevistados: {totalEntrevistados}");

  Console.WriteLine($"Percentual de pessoas que gostam de esportes: {percentualEsportes}%");



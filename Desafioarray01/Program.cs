
int[] numeros = new int[6];
int Par = 0, Impar = 0;

for (int i = 0; i < 6; i++)
{
    Console.Write($"Digite o {i + 1}º número: ");
    int numeroDigitado = int.Parse(Console.ReadLine()!);
    numeros[i] = numeroDigitado;
}

for (int i = 0; i < 6; i++)
{
    if (numeros[i] % 2 == 0)
    { Par++; }
    else
    {
  

        Impar++;
    }
}


Console.WriteLine("\nQuantidade de números pares: " + Par);
for (int i = 0; i < 6; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine($"{numeros[i]}");

    }

}


Console.WriteLine("Quantidade de números ímpares: " + Impar);

for (int i = 0; i < 6; i++)
{
    if (numeros[i] % 2 == 1)
    {
        Console.WriteLine($"{numeros[i]}");
    }

}
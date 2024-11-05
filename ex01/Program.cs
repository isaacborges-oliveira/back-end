using System;

class Program
{
    static void Main()
    {
        string nome = "João";
        double nota1 = 8.0;
        double nota2 = 7.5;
        
        double media = CalcularMedia(nota1, nota2);
        Console.WriteLine("Aluno: " + nome);
        Console.WriteLine("Média: " + media);
    }

    static double CalcularMedia(double nota1, double nota2)
    {
        return (nota1 + nota2) / 2;
    }
}

using System;

class Aluno
{
    public string Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    public Aluno(string nome, double nota1, double nota2)
    {
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
    }

    public double CalcularMedia()
    {
        return (Nota1 + Nota2) / 2;
    }
}

class Program
{
    static void Main()
    {
        Aluno joao = new Aluno("João", 8.0, 7.5);
        Console.WriteLine("Aluno: " + joao.Nome);
        Console.WriteLine("Média: " + joao.CalcularMedia());

        Aluno isaac = new Aluno("Isaac", 8.0, 7.5);
        Console.WriteLine("Aluno: " + isaac.Nome);
        Console.WriteLine("Média: " + isaac.CalcularMedia());
    }
}

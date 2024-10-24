

Console.Write("Entre com o valor do salario recebido ");
float salario = float.Parse(Console.ReadLine()!);

Console.Write ("Entre com o valor gasto: ");
float gastos = float.Parse(Console.ReadLine()!);



if(salario >= gastos)

{
    Console.WriteLine ("Gasto dentro do orcamento");
}
else
{
    Console.WriteLine ("Orcamento estourado");
}

using pilaresoo.Classes.Pilares;
Console.Clear();

Corrente contadoisaac = new Corrente();
contadoisaac.Titular = "Isaac Borges Oliveira";

Console.WriteLine($"Saldo da conta: {contadoisaac.getsaldo}");
Console.WriteLine($"Titular da conta: {contadoisaac.Titular}");



float valorsacado = contadoisaac.Sacar (1200f);

Console.WriteLine($"valor do saque: {contadoisaac.getsaldo}");

Console.WriteLine($"valor do saldo: {contadoisaac.getsaldo}");

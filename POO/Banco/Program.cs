using Banco.Classes;

Console.Clear();
Console.WriteLine($"Bem vindo ao Nubanquinho");
Console.WriteLine();



ContaCorrente contaIsaac = new ContaCorrente();
ContaCorrente ContaEmilly = new ContaCorrente();



contaIsaac.Titular = "Isaac";
contaIsaac.Depositar(1000f);

ContaEmilly.Titular = "Emilly";
ContaEmilly.Depositar(1000f);

Console.WriteLine($"Conta da {contaIsaac} tem R${contaIsaac.Saldo}");
Console.WriteLine($"Conta da {ContaEmilly} tem R${ContaEmilly.Saldo}");
ContaEmilly.Sacar(250f);

Console.WriteLine($"Voce sacou e sua conta ficou com R$ {ContaEmilly.Saldo}");
Console.WriteLine($"");
Console.WriteLine($"");

Console.WriteLine($"conta da {contaIsaac.Titular} tem R$ {contaIsaac.Saldo}");
Console.WriteLine($"conta da {ContaEmilly.Titular} tem R$ {ContaEmilly.Saldo}");

Console.WriteLine($"");




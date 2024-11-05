using ClasseObjetos.Classes;


Animal cachorro = new Animal();

cachorro.nome = "Princesa";
cachorro.raca = "Shitzu";
cachorro.cor = "Preto e Branco";
cachorro.idade = 5;

Animal cavalo = new Animal();

cavalo.nome = "rock";
cavalo.raca = "Arabe";
cavalo.cor = "Preto e Branco";
cavalo.idade = 3;

// Console.WriteLine($" Animal: 1");
// Console.WriteLine($"-----------");

// Console.WriteLine($"Nome: {cachorro.nome}");
// Console.WriteLine($"Raca: {cachorro.raca}");
// Console.WriteLine($"cor: {cachorro.cor}");
// Console.WriteLine($"idade do {cachorro.nome} é {cachorro.idade}");

Console.WriteLine($"");

cachorro.fazerBarulho("auau");
Console.WriteLine($"Idade de  {cachorro.nome} e {cachorro.idade}");
cachorro.envelhecer();
Console.WriteLine($"Nova idade de {cachorro.nome} e {cachorro.idade}");

Console.WriteLine($"");


cavalo.fazerBarulho();
Console.WriteLine($"Idade de  {cavalo.nome} e {cavalo.idade}");
cachorro.envelhecer();
Console.WriteLine($"Nova idade de {cavalo.nome} e {cavalo.idade}");



// Console.WriteLine($" Animal: 2");
// Console.WriteLine($"-----------");

// Console.WriteLine($"Nome: {cavalo.nome}");
// Console.WriteLine($"Raca do: {cavalo.raca}");
// Console.WriteLine($"cor do: {cavalo.cor}");
// Console.WriteLine($"idade do {cavalo.nome} é {cavalo.idade}");




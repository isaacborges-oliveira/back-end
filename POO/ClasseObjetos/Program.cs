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


Console.WriteLine($"Nome do cachorrinho:{cachorro.nome}");
Console.WriteLine($"Raca do :{cachorro.raca}");
Console.WriteLine($"cor do :{cachorro.cor}");
Console.WriteLine($"idade do {cachorro.nome}:{cachorro.idade}");



Console.WriteLine($"Nome do cachorrinho:{cavalo.nome}");
Console.WriteLine($"Raca do :{cavalo.raca}");
Console.WriteLine($"cor do :{cavalo.cor}");
Console.WriteLine($"idade do {cavalo.nome}:{cavalo.idade}");




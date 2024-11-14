// using pilaresoo.Classes;
// using pilaresoo.Classes.Aprendizagem;




// Pessoas isaac = new Pessoas();
// isaac.Nome = "isaac";


// Professor sam = new Professor (12343);

// ALuno isaacborgees = new ALuno();
// isaacborgees.Aluno = "isaac Boges" ;
// isaacborgees.idade = 17;
// isaacborgees.CPF = 334455;
// isaacborgees.Peso = 80;
// isaacborgees.Altura = 1.80f;
// isaacborgees.Matricula = 12345 ;
// isaacborgees.Curso = "Dev";
// isaacborgees.media = 7.9F;


// Console.WriteLine($"Curso: {isaacborgees.Curso}");
// Console.WriteLine($"Professor: {sam.Nome}");


// Console.WriteLine($"Aluno: {isaacborgees.Aluno}");
// Console.WriteLine($"Idade: {isaacborgees.idade}");
// Console.WriteLine($"CPF: {isaacborgees.CPF}");
// Console.WriteLine($"PESO: {isaacborgees.Peso}");
// Console.WriteLine($"ALtura: {isaacborgees.Altura}");
// Console.WriteLine($"Matricula: {isaacborgees.Matricula}");
// Console.WriteLine($"Curso: {isaacborgees.Curso}");
// Console.WriteLine($"Media: {isaacborgees.media}");
// Console.WriteLine($"{isaac.Nome} Nasceu com {isaac.idade}");




using System.Diagnostics.Contracts;
using pilaresoo.Classes;



carro skiline  = new carro();
skiline.marca = "nissan";
skiline.modelo = "skiline";
skiline.cor = "preto";
skiline.potencia = 222;
skiline.portas = 4;



Aviao asas = new Aviao();

asas.marca = "bong";
asas.modelo = "747";
asas.cor = "branco";
asas.potencia = 2222;
asas.portas = 8;


Moto ran = new Moto();
ran.marca = "TRIUMPH";
ran.modelo = "Tiger";
ran.cor = "vermelho";
ran.potencia = 2222;
ran.rodas = 2;



Console.WriteLine($@"seu carro: 
Marca:{skiline.marca}
Modelo:{skiline.modelo}
Cor:{skiline.cor}
Potencia:{skiline.potencia}
POrta:{skiline.portas}
");

Console.WriteLine($@"seu aviao: 
Maraca:{asas.marca}
MOdelo:{asas.modelo}
Cor:{asas.cor}
Potencia:{asas.potencia}
Portas:{asas.portas}
");

Console.WriteLine($@"sua moto: 
Marca:{ran.marca}
Modelo:{ran.modelo}
Cor:{ran.cor}
Potencia:{ran.potencia}
Rodas:{ran.rodas}
");



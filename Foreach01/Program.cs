string[] frutas = { "Melancia", "Carambola", "Maracuja", "Morango", "Limao", "Jabuticaba", "Abacate", "Kiwi", "Acelora", "Pinha", "Lichia", "Pitaya", "Pessego", "Banana" };

Console.WriteLine($"sua sacola contem {frutas.Length} Frutas!");

foreach (string f in frutas)
{
    Console.WriteLine($"{f}, ");
    
}
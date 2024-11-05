namespace ClasseObjetos.Classes
{
    public class Animal
    {
        public string raca;
        public string cor;
        public string nome;
        public int idade = 0;
      
     public void fazerBarulho(string Barulho = "Barulho generico")
     {
        Console.WriteLine($"Barulho do animal: {Barulho}");

     }
     public void envelhecer()
     {
        idade = idade +1 ;
     }
    }
}
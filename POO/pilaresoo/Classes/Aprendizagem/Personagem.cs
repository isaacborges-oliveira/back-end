namespace pilaresoo.Classes.Aprendizagem
{
    public abstract class Personagem 
    {
        public string? Nome; 
        public string?  Idade;
        public string?  Peso;

         public abstract  void  Atacar();
    
         public virtual void Defender()
        {

            Console.WriteLine($"Boa {Nome} vc defendeu!");


        }
         public virtual void Curar(){

            Console.WriteLine($"Quase {Nome} ainda bem que tinha cura!");
            
        }
        public virtual void Morrer(){

            Console.WriteLine($"inutil {Nome} esoerava mais!");
            
        }
    }
}
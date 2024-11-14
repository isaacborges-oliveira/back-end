namespace pilaresoo.Classes.Aprendizagem
{
    public class Professor
    {
    
        public string? Nome;
        public int NIF {get; set;}
        public int Salario { get; set; }
        public Professor(int _nif)
        {
           NIF = _nif; 
        }
    }
}
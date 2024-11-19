namespace pilaresoo.Classes.Aprendizagem
{
    public class Pessoas
    {
        public string? Nome;
        public int idade;
        public int CPF;
        public float Peso {get; set; }
        public float Altura {get; set; }
        
        
        public void Envelhecer(){

            idade ++;
        }
        public void Engordar(float _kg){

            Peso = Peso + _kg;
        }
        public void Emagrecer(float _kg){

            Peso = Peso - _kg;
        }
    }
    public class ALuno : Pessoas{
        public string? Aluno {get; set;}
        public int Matricula {get; set;}
        public string? Curso {get; set;}
        public float media {get; set;}
    }
}
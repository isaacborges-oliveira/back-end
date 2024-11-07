namespace Construtores.Classes
{
    public class Alunos
    {
    public string  nome { get; set; } 
     public int  idade { get; set; }
     public int  matricula { get; set; }
     
     
public Alunos(string no, int id, int ma){

    nome = no;
    idade = id;
    matricula = ma;
   
}



public Alunos (){

    Console.WriteLine($"O aluno foi cadastrado");
    
}


 public void Exibirdados(){
 Console.WriteLine($@"
 ******************
 nome: {nome}   *
 idade: {idade} *
 matricula: {matricula}       *       
 ******************
 ");
 }
    }
    }
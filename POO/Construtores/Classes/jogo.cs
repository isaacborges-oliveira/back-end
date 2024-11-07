namespace Construtores.Classes
{
    public class jogos
    {
    public string  nome { get; set; } 
     public int  lancamento { get; set; }
     public string  genero { get; set; }
     public int  preco { get; set; }
     
public jogos (string no, int la, string ge, int pc){

    nome = no;
    lancamento = la;
    genero = ge;
    preco = pc;
}



public jogos (){

    Console.WriteLine($"O jogo foi comprado");
    
}


 public void Exibirdados(){
 Console.WriteLine($@"
 ******************
 Marca: {nome}   *
 modelo: {lancamento} *
 ano: {genero}       *
 cor: {preco}       *
 ******************
 ");
 }
    }
    }
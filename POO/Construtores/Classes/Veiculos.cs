using System.Security.Cryptography;

namespace Construtores.Classes
{
    public class Veiculos
    {
    public string  marca { get; set; } 
     public string  modelo { get; set; }
     public int  ano { get; set; }
     public string  cor { get; set; }
     
public Veiculos (string ma, string md, int an, string cr){

    marca =ma;
    modelo= md;
    ano = an;
    cor = cr;
}



public Veiculos (){

    Console.WriteLine($"O carro foi criado");
    
}


 public void Exibirdados(){
 Console.WriteLine($@"
 ******************
 Marca: {marca}   *
 modelo: {modelo} *
 ano: {ano}       *
 cor: {cor}       *
 ******************
 ");
 }
    }
}
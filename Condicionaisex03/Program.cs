int equilatero =3;
   int isoceles =2;
    int escaleno =3;
    int resultado ;

Console.WriteLine("Qual as medidas do seu triangulo ?");
resultado = int.Parse(Console.ReadLine());
Console.WriteLine("");

if (resultado >= equilatero)
{
     Console.WriteLine("Triângulo    Equilátero");
   
} else if (resultado <= isoceles)
{
    Console.WriteLine("Triângulo    isoceles");
} else {
   Console.WriteLine("seu Triângulo  pode ser ou  escaleno ou isoceles");
}

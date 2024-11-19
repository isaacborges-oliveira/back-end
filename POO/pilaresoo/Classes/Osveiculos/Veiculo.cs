namespace pilaresoo.Classes
{
    public abstract class Veiculo
    {
        public string? marca ;
        public string? modelo;
        public string? cor;
        public int potencia;
        public int passageiros;

        public void Ligar()
        {

            Console.WriteLine($"carro ligar");


        }
        public void desligar()
        {

            Console.WriteLine($"carro desligar");

        }
        public void Buzinar()
        {

            Console.WriteLine($"carro desligar");

        }
    }

}
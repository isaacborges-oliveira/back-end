namespace Personagem.classe
{
    public class Jogador
    {
        public string Nome;
        public int Idade;
        public string Armadura;
        public string InteligenciaArtificial;

        

        public void Atacar(string nome)
        {
            Console.WriteLine($"na mosca seu  personagem ({nome})  atacou!");
        }


        public void Defender(string nome)
        {
            Console.WriteLine($"Boa mlk seu personagem ({nome}) defendeu!");

        }


        public void RestaurarArmadura(string nome)
        {
            Console.WriteLine($"O seu personagem ({nome})  restaurou a armadura!");
        }
    }
}
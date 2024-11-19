namespace pilaresoo.Classes.Pilares
{
    public class Poupanca : Conta
    {
        public int limitesaque;
       public float  rendimentos;

        public override bool Depositar(float valor)
        {
            throw new NotImplementedException();
        }

        public override float Sacar(float valor)
        {
            throw new NotImplementedException();
        }

    }
}
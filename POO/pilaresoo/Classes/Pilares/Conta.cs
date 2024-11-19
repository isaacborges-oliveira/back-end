namespace pilaresoo.Classes.Pilares
{
    public abstract class Conta
    {
        public string? Titular;
        protected float Saldo;
     

public abstract float Sacar (float valor);




public abstract bool Depositar (float valor);


public float getsaldo(){
    return Saldo;
}
}
}
namespace Exer01
{
    public class CabinePedagio
    {
        private double valorEixo;
        private double saldo;

        public CabinePedagio(double valorEixo)
        {
            this.valorEixo = valorEixo;
            this.saldo = 0.0;
        }

        public double GetValorEixo()
        {
            return valorEixo;
        }
        public double GetSaldo()
        {
            return saldo;
        }

        public bool Pedagio(Veiculos veiculos)
        {
            double valorCobrado = veiculos.GetNumEixos() * valorEixo;

            if(veiculos is Motocicleta)
            {
                valorCobrado *= 0.5;
            }
            else if(veiculos is Veiculos)
            {
                valorCobrado *= 2;
            }

            if (veiculos.GetSaldo() < valorCobrado)
            {
                return false;
            }
            else
            {
                this.saldo += valorCobrado;
                veiculos.DiminuirSaldo(valorCobrado);
                return true;
            }
        }
    }
}
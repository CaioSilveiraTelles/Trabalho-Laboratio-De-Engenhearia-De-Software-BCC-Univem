namespace Exer01
{
  public class Veiculos
  {
    private string placa;
    private int numEixos;
    private double saldo;    

    public Veiculos(string placa, 
                    int numEixos,
                    double saldo)
    {
      this.placa = placa;
      this.numEixos = numEixos;
      this.saldo = saldo;
    }
    public string GetPlaca()
    {
      return placa;
    }
    public int GetNumEixos()
    {
      return this.numEixos;
    }
    public double GetSaldo()
    {
      return this.saldo;
    }
    public void DiminuirSaldo(double valor)
    {
        this.saldo -= valor;
    }
  }
}
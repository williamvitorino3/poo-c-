namespace conta
{
  public abstract class Conta
  {
    public virtual string Id { get; set; }
    public double saldo { get; set; }
    public string titular { get; set; }

    
    public Conta(string titular)
    {
      this.titular = titular;
    }

    public virtual void Depositar(double valor)
    {
      this.saldo += valor;
    }
    public virtual void Sacar(double valor)
    {
      this.saldo -= ( valor <= saldo ? valor : 0);
    }
  }
}
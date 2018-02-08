namespace conta
{
  public abstract class Conta
  {
    public virtual string Id { get; set; }
    public decimal saldo { get; set; }
    public string titular { get; set; }

    
    public Conta(string titular)
    {
      this.titular = titular;
    }

    public virtual void Depositar(decimal valor)
    {
      this.saldo += valor;
    }
    public virtual void Sacar(decimal valor)
    {
      this.saldo -= ( valor <= saldo ? valor : 0);
    }
  }
}
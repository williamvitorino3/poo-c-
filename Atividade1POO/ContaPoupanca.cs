using System;

namespace conta
{
  public abstract class ContaPoupanca : Conta
  {
    public override string Id { get {return titular + " (CP)";} }
    private decimal taxaJuros { get; set; }
    private DateTime dataAniversario { get; set; }

    public ContaPoupanca(decimal taxaJuros, DateTime dataAniversario, string titular): base(titular)
    {
      this.taxaJuros = taxaJuros;
      this.dataAniversario = dataAniversario;
    }

    public void AdicionarRendimento()
    {
      if(DateTime.Now.Equals(this.dataAniversario))
      {
        Depositar(saldo * this.taxaJuros); 
      }
    }
  }
}
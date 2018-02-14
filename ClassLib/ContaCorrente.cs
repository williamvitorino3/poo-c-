using System;

namespace conta
{
  public class ContaCorrente : Conta
  {
    public const double Taxa = 0.10;
    public override string Id { get {return titular + " (CC)";} }
    public ContaCorrente(double taxaJuros, DateTime dataAniversario, string titular): base(titular)
    {}

    public override void Depositar(double valor)
    {
      base.Depositar(valor - (valor * Taxa));
    }
    public override void Sacar(double valor)
    {
      base.Sacar(valor + (valor * Taxa));
    }
  }
}
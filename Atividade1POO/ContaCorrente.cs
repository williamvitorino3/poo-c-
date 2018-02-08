using System;

namespace conta
{
  public abstract class ContaCorrente : Conta
  {
    public const decimal Taxa = 0.10M;
    public override string Id { get {return titular + " (CC)";} }
    public ContaCorrente(decimal taxaJuros, DateTime dataAniversario, string titular): base(titular)
    {}

    public override void Depositar(decimal valor)
    {
      base.Depositar(valor - (valor * Taxa));
    }
    public override void Sacar(decimal valor)
    {
      base.Sacar(valor + (valor * Taxa));
    }
  }
}
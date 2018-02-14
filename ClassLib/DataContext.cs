using Microsoft.EntityFrameworkCore;
using conta;

namespace DataContext
{
  public class Context: DbContext
  {
    public DbSet<Conta> Contas { get; set; }
    public DbSet<ContaCorrente> ContaCorrente { get; set; }
    public DbSet<ContaPoupanca> ContaPoupanca { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("server=localhost;database=library;Trusted_Connection=True;");
    }
  }
}
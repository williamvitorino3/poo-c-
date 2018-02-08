using Microsoft.EntityFrameworkCore;

namespace DataContext
{
  public class DataContext: DbContext
  {
    public DbSet<Conta> Contas { get; set; }
    public DbSet<ContaCorrente> ContasCorrente { get; set; }
    public DbSet<ContaPoupanca> ContasPoupanca { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=library;user=root;password=root");
    }
  }
}
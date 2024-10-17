using MatheusLopes.funcionario;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Funcionario> funcionarios { get; set; }
    public DbSet<FolhaPagamento> folhaPagamentos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=nomeDoSeuBanco.db");
    }
}
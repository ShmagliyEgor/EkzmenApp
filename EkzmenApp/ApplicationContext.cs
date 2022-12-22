using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EkzmenApp;
using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<Book> Book { get; set; }
    public DbSet<Avtor> Avtor { get; set; }
    public DbSet<Janr> Janr { get; set; }
    public DbSet<Izdatelstvo> Izdatelstvo { get; set; }
    public DbSet<Stelaj> Stelaj { get; set; }
    public DbSet<Buybook> Buybook { get; set; }
    public DbSet<Otchet> Otchet { get; set; }
    public DbSet<Buy> Buy { get; set; }
    public DbSet<AvtorBook> AvtorBook { get; set; }
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"data source =323-7\SQLEXPRESS; initial catalog = ChitayGorod; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework");
    }
}
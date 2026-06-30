using MagazynApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MagazynApp.Data;

public class MagazynContext : DbContext
{
    public MagazynContext(DbContextOptions<MagazynContext> options) : base(options)
    {
    }

    public DbSet<Produkt> Produkty => Set<Produkt>();
}

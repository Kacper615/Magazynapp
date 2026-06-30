using MagazynApp.Models;

namespace MagazynApp.Data;

public static class SeedData
{
    public static void Initialize(MagazynContext context)
    {
        if (context.Produkty.Any())
        {
            return;
        }

        context.Produkty.AddRange(
            new Produkt
            {
                Nazwa = "Laptop Dell XPS 15",
                Opis = "Laptop biznesowy, 16 GB RAM, SSD 512 GB",
                Kategoria = "Elektronika",
                Ilosc = 12,
                Cena = 5499.99m,
                DataDodania = DateTime.Now.AddDays(-10)
            },
            new Produkt
            {
                Nazwa = "Krzesło biurowe",
                Opis = "Ergonomiczne krzesło z regulacją wysokości",
                Kategoria = "Meble",
                Ilosc = 35,
                Cena = 449.00m,
                DataDodania = DateTime.Now.AddDays(-5)
            },
            new Produkt
            {
                Nazwa = "Papier A4",
                Opis = "Ryza 500 arkuszy, 80 g/m²",
                Kategoria = "Biuro",
                Ilosc = 120,
                Cena = 24.99m,
                DataDodania = DateTime.Now.AddDays(-2)
            }
        );

        context.SaveChanges();
    }
}

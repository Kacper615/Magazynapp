using System.ComponentModel.DataAnnotations;

namespace MagazynApp.Models;

public class Produkt
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nazwa jest wymagana.")]
    [StringLength(100, ErrorMessage = "Nazwa może mieć maksymalnie 100 znaków.")]
    public string Nazwa { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "Opis może mieć maksymalnie 500 znaków.")]
    public string? Opis { get; set; }

    [Required(ErrorMessage = "Kategoria jest wymagana.")]
    public string Kategoria { get; set; } = "Inne";

    [Range(0, int.MaxValue, ErrorMessage = "Ilość nie może być ujemna.")]
    public int Ilosc { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "Cena nie może być ujemna.")]
    public decimal Cena { get; set; }

    public DateTime DataDodania { get; set; } = DateTime.Now;
}

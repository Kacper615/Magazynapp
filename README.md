# System Magazynowy

Aplikacja webowa do ewidencji towarów stworzona w technologii **Blazor Server (.NET 8)**.

**Autor:** Kacper Kopaczewski · nr albumu 13030

**Repozytorium:** https://github.com/Kacper615/MagazynApp

## Główne Funkcjonalności

* **Zarządzanie produktami:** Dodawanie nowych towarów oraz edycja istniejących.
* **Usuwanie danych:** Możliwość trwałego usunięcia produktu z bazy.
* **Wyszukiwarka:** Filtrowanie listy produktów po nazwie i kategorii.
* **Walidacja danych:** System sprawdza, czy pola są poprawnie wypełnione.
* **Trwałość danych:** Zapis i odczyt bazy danych SQLite (plik `magazyn.db`).

## Technologie

* **Język:** C#
* **Interfejs:** Blazor Server (Razor)
* **Backend:** ASP.NET Core
* **Baza danych:** Entity Framework Core + SQLite

## Jak uruchomić projekt?

1. Pobierz lub sklonuj repozytorium.
2. Otwórz plik `MagazynApp.sln` w programie Visual Studio **lub** w terminalu przejdź do folderu `MagazynApp` i uruchom `dotnet run --launch-profile https`.
3. Otwórz przeglądarkę pod adresem **https://localhost:7280** (lub http://localhost:5280).
4. Skompiluj i uruchom projekt (F5 w Visual Studio).

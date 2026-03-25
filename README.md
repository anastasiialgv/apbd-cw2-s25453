# apbd-cw2-s25453
APBD Homework #3
## Opis projektu
Aplikacja konsolowa w języku C# służąca do zarządzania uczelnianą wypożyczalnią sprzętu. System umożliwia rejestrację różnych typów urządzeń (laptopy, aparaty, projektory), zarządzanie użytkownikami (studenci, pracownicy) oraz obsługę procesu wypożyczeń wraz z naliczaniem kar za opóźnienia.

## Struktura projektu
Projekt został podzielony zgodnie z zasadami programowania obiektowego (OOP):
- **Modele domenowe**: Klasy `User` i `Equipment` wraz z ich specjalizacjami.
- **Logika biznesowa**: Klasa `Service`, która izoluje reguły wypożyczalni od interfejsu użytkownika.
- **Obiekty transakcyjne**: Klasa `Rental` przechowująca dane o konkretnej operacji wypożyczenia.

## Decyzje projektowe i dobre praktyki

### 1. Kohezja (Cohesion)
Zadbałam o wysoką spójność klas poprzez ścisły podział odpowiedzialności:
- Klasy takie jak `Laptop`, `Camera` czy `Projector` są klasami typu "data container" z minimalną logiką (głównie `ToString`).
- Cała logika sprawdzania limitów, weryfikacji dostępności oraz obliczania kar znajduje się wyłącznie w klasie `Service`. Dzięki temu każda klasa robi tylko to, do czego została stworzona.

### 2. Powiązanie (Coupling)
W celu uzyskania niskiego poziomu powiązania (Low Coupling):
- Klasy sprzętu (`Equipment`) nie wiedzą nic o użytkownikach (`User`).
- Klasa `Service` operuje na abstrakcjach. Metoda `RentItem` przyjmuje bazowy typ `User`, nie interesując się, czy jest to `Student` czy `Employee` – limity są pobierane polimorficznie przez właściwość `MaxRental`.

### 3. Dziedziczenie i Polimorfizm
- Wykorzystałam klasy abstrakcyjne dla `User` i `Equipment`, ponieważ nie istnieje w systemie "sprzęt ogólny" – zawsze jest to konkretne urządzenie.
- Polimorfizm pozwala na łatwe dodawanie nowych typów użytkowników lub sprzętu bez modyfikacji głównej logiki wypożyczania.

### 4. Obsługa błędów
Zgodnie z wymaganiami, operacje, które mogą się nie powieść (np. przekroczenie limitu wypożyczeń lub próba wypożyczenia niedostępnego sprzętu), rzucają wyjątki `Exception`, które są jawnie obsługiwane w `Program.cs`.

## Reguły biznesowe
Student: limit 2 aktywne wypożyczenia.
Pracownik: limit 5 aktywnych wypożyczeń.
Kary: naliczane za każdy dzień zwłoki po terminie `PlannedReturnDate`.

## Instrukcja uruchomienia
1. Upewnij się, że masz zainstalowane .NET SDK 9.0.
2. Sklonuj repozytorium.
3. W folderze projektu wykonaj:
   ```bash
   dotnet restore
   dotnet run
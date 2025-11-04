using System;

class Program
{
    static void Main()
    {
        // Symulacja danych użytkownika
        string imie = "Anna";
        string nazwisko = "Kowalska";
        string wiekString = "28";
        string email = "anna.kowalska@example.com";
        string telefon = "123456789";

        // Zmienne logiczne do przechowywania wyników walidacji
        bool imieOK = false;
        bool nazwiskoOK = false;
        bool wiekOK = false;
        bool emailOK = false;
        bool telefonOK = false;

        // Walidacja imienia
        if (!string.IsNullOrWhiteSpace(imie))
        {
            imieOK = true;
            Console.WriteLine($"Imię  OK");
        }
        else
        {
            Console.WriteLine($"Imię  Błąd: pole nie może być puste");
        }

        // Walidacja nazwiska
        if (!string.IsNullOrWhiteSpace(nazwisko))
        {
            nazwiskoOK = true;
            Console.WriteLine($"Nazwisko  OK");
        }
        else
        {
            Console.WriteLine($"Nazwisko  Błąd: pole nie może być puste");
        }

        // Walidacja wieku (TryParse + zakres)
        if (int.TryParse(wiekString, out int wiek))
        {
            if (wiek >= 18 && wiek <= 100)
            {
                wiekOK = true;
                Console.WriteLine($"Wiek  OK");
            }
            else
            {
                Console.WriteLine($"Wiek  Błąd: wiek musi być w przedziale 18–100");
            }
        }
        else
        {
            Console.WriteLine($"Wiek  Błąd: wartość nie jest liczbą");
        }

        // Walidacja adresu e-mail
        if (!string.IsNullOrWhiteSpace(email) && email.Contains("@"))
        {
            emailOK = true;
            Console.WriteLine($"Email  OK");
        }
        else
        {
            Console.WriteLine($"Email  Błąd: nieprawidłowy adres e-mail");
        }

        // Walidacja numeru telefonu
        if (telefon.Length == 9 && long.TryParse(telefon, out _))
        {
            telefonOK = true;
            Console.WriteLine($"Numer telefonu  OK");
        }
        else
        {
            Console.WriteLine($"Numer telefonu  Błąd: numer musi zawierać dokładnie 9 cyfr");
        }

        // Podsumowanie walidacji
        bool wszystkieOK = imieOK && nazwiskoOK && wiekOK && emailOK && telefonOK;

        Console.WriteLine();
        if (wszystkieOK)
        {
            Console.WriteLine("Wszystkie dane są poprawne. Rejestracja zakończona sukcesem!");
        }
        else
        {
            Console.WriteLine("Formularz zawiera błędy. Popraw dane i spróbuj ponownie.");
        }
    }
}

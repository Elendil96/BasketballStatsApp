namespace BasketballStatsApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Witaj w programie do prowadzenia statystyki punktów zdotbytych w meczach koszykarskich");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine();
                Console.WriteLine("1. Dodaj punkty zawodnikowi (zapis danych do pliku) oraz wyświetl statystyki -----> Kliknij przycisk 1");
                Console.WriteLine();
                Console.WriteLine("2. Dodaj punkty zawodnikowi (zapis danych w pamięci programu) oraz wyświetl statystyki -----> Kliknij przycisk 2");
                Console.WriteLine();
                Console.WriteLine("3. Zamknięcie programu -----> Kliknij przycisk 3");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();
                Console.Write("Wybierz opcję: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        UsePlayerInFile();
                        break;
                    case "2":
                        UsePlayerInMemory();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie.");
                        break;
                }
            }
        }

        private static void UsePlayerInFile()
        {
            Console.WriteLine();
            Console.Write("Podaj imię: ");
            string name = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string surname = Console.ReadLine();

            Console.Write("Podaj klub: ");
            string club = Console.ReadLine();

            PlayerInFile player = new PlayerInFile(name, surname, club);

            Console.WriteLine();
            Console.WriteLine("Ilość punktów wpisz jako wartość liczbową od 1 do 100 lub jako wartość literową od A/a do E/e (A/a - 100 pkt, B/b - 80 pkt, C/c - 60 pkt, D/d - 40 pkt, E/e - 20 pkt)");
            Console.WriteLine();
            Console.Write("Podaj liczbę punktów: ");

            while (true)
            {
                string scoreInput = Console.ReadLine();

                if (scoreInput == "x")
                {
                    break;
                }
                try
                {
                    player.AddScore(scoreInput);
                    Console.WriteLine();
                    Console.WriteLine("Punkty za mecz dodane pomyślnie. Podaj punkty zdobyte w kolejnym meczu lub przejdź do statystyk wpisując x");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Statystyki:");
            var statisctics = player.GetStatistics();
            Console.WriteLine();
            Console.WriteLine($"Średnia liczba punktów zdobtya na mecz: {statisctics.Average}");
            Console.WriteLine($"Minimalna liczba punktów zdobyta w meczu: {statisctics.Min}");
            Console.WriteLine($"Maksymalna liczba punktów zdobyta w meczu: {statisctics.Max}");
            Console.WriteLine($"Ocena literowa: {statisctics.AverageLetter}");
            Console.WriteLine($"Ilość rozgeranych meczy: {statisctics.Count}");
            Console.WriteLine($"Liczba punktów zdobyta we wszystkich meczach: {statisctics.Sum}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

        }


        private static void UsePlayerInMemory()
        {
            Console.WriteLine();
            Console.Write("Podaj imię: ");
            string name = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string surname = Console.ReadLine();

            Console.Write("Podaj klub: ");
            string club = Console.ReadLine();

            PlayerInMemory player = new PlayerInMemory(name, surname, club);

            Console.WriteLine();
            Console.WriteLine("Ilość punktów wpisz jako wartość liczbową od 1 do 100 lub jako wartość literową od A/a do E/e (A/a - 100 pkt, B/b - 80 pkt, C/c - 60 pkt, D/d - 40 pkt, E/e - 20 pkt)");
            Console.WriteLine();
            Console.Write("Podaj liczbę punktów: ");

            while (true)
            {
                string scoreInput = Console.ReadLine();

                if (scoreInput == "x")
                {
                    break;
                }
                try
                {
                    player.AddScore(scoreInput);
                    Console.WriteLine();
                    Console.WriteLine("Punkty za mecz dodane pomyślnie. Podaj punkty zdobyte w kolejnym meczu lub przejdź do statystyk wpisując x");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Statystyki:");
            var statisctics = player.GetStatistics();
            Console.WriteLine();
            Console.WriteLine($"Średnia liczba punktów zdobtya na mecz: {statisctics.Average}");
            Console.WriteLine($"Minimalna liczba punktów zdobyta w meczu: {statisctics.Min}");
            Console.WriteLine($"Maksymalna liczba punktów zdobyta w meczu: {statisctics.Max}");
            Console.WriteLine($"Ocena literowa: {statisctics.AverageLetter}");
            Console.WriteLine($"Ilość rozgeranych meczy: {statisctics.Count}");
            Console.WriteLine($"Liczba punktów zdobyta we wszystkich meczach: {statisctics.Sum}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
}




























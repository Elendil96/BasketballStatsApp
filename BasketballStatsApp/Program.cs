using BasketballStatsApp;

//Console.WriteLine("Witaj w programie do zliczania punktów zdobytytcyh przez zaowdników");
//Console.WriteLine("-------------------------------------------------------------------");
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine("Aby przejść dalej wybierz jedną w dwóch dostępnych opcji");
//Console.WriteLine();
//Console.WriteLine("1. Zapisz zdobyte punkty przez zawodnika do pliku ----> Wciśnij 1");
//Console.WriteLine();
//Console.WriteLine("2. Zapisz zdobyte punkty przez zawodnika w pamięci programu ----> Wciśnij 2");
//Console.WriteLine();
//Console.WriteLine("3.Zamknij pogram ----> Wciśnij 3");











//var player = new PlayerInMemory("", "", "");
//player.ScoreAdded += PlayerScoreAdded;

//void PlayerScoreAdded(object sender, EventArgs args)
//{
//    Console.WriteLine("Dodano nową ocenę");
//}











//string choice = Console.ReadLine();

//switch (choice)
//{
//    case "1":
//    Option1:
//        break;
//    case "2":
//    Option2:
//        break;
//    case "3":
//    Option3:
//        break;
//    default:
//        Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
//        break;
//}

//static void Option1(PlayerInMemory)
//{
//    Console.WriteLine("Wybrano opcję 1. Wprowadź dane, a następnie zatwierdź klawiszem K");
//    Console.WriteLine("Podaj imię zawodnika:");
//    string name = Console.ReadLine();
//    player.Name = name;

//    Console.WriteLine("Podaj nazwisko zawodnika:");
//    string surnname = Console.ReadLine();
//    player.Surname = name;

//    Console.WriteLine("Podaj drużynę zawodnika:");
//    string club = Console.ReadLine();
//    player.Club = name;
//}




using System;

namespace BasketballStatsApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine();
                Console.WriteLine("1. Dodaj punkty zawodnikowi (zapis danych do pliku) oraz wyświetl statystyki -----> Kliknij przycisk 1");
                Console.WriteLine();
                Console.WriteLine("2. Dodaj punkty zawodnikowi (zapis danych w pamięci programu) oraz wyświetl statystyki -----> Kliknij przycisk 2");
                Console.WriteLine();
                Console.WriteLine("3. Zamknięcie programu -----> Kliknij przycisk 3");
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
            Console.Write("Podaj ilość zdobytych punktów: ");
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
                    Console.WriteLine("Punkty za mecz dodane pomyślnie. Podaj punkty zdobyte w kolejnym meczu lub przejdź do statystyk wpisując x");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }

            Console.WriteLine("Statystyki:");
            var statisctics = player.GetStatistics();
            Console.WriteLine();
            Console.WriteLine($"AVG: {statisctics.Average}");
            Console.WriteLine($"MIN: {statisctics.Min}");
            Console.WriteLine($"MAX: {statisctics.Max}");
            Console.WriteLine($"AVG LETTER: {statisctics.AverageLetter}");
            Console.WriteLine($"COUNT: {statisctics.Count}");
            Console.WriteLine($"SUM: {statisctics.Sum}");
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
            Console.Write("Podaj ilość zdobytych punktów: ");
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
                    Console.WriteLine("Punkty za mecz dodane pomyślnie. Podaj punkty zdobyte w kolejnym meczu lub przejdź do statystyk wpisując x");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd: {ex.Message}");
                }
            }

            Console.WriteLine("Statystyki:");
            var statisctics = player.GetStatistics();
            Console.WriteLine();
            Console.WriteLine($"AVG: {statisctics.Average}");
            Console.WriteLine($"MIN: {statisctics.Min}");
            Console.WriteLine($"MAX: {statisctics.Max}");
            Console.WriteLine($"AVG LETTER: {statisctics.AverageLetter}");
            Console.WriteLine($"COUNT: {statisctics.Count}");
            Console.WriteLine($"SUM: {statisctics.Sum}");
            Console.WriteLine();
        }

    }
}




























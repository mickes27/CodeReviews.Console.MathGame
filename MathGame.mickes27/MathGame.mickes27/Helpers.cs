using MathGame.mickes27.Models;

namespace MathGame.mickes27;

public class Helpers
{
    private static List<Game> games = [];

    internal static void PrintGames()
    {
        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("----------------------------------------------------------------");
        foreach (var game in games) {
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} points.");
        }

        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine("Press any key to go back to Main Menu.");
        Console.ReadKey();
    }

    internal static void AddToHistory(int gameScore, GameType gameType)
    {
        games.Add(new Game { Date = DateTime.UtcNow, Type = gameType, Score = gameScore });
    }

    internal static int[] GetDivisionNumbers()
    {
        var random = new Random();

        var firstNumber = random.Next(1, 99);
        var secondNumber = random.Next(1, 99);

        while (firstNumber % secondNumber != 0) {
            firstNumber = random.Next(1, 99);
            secondNumber = random.Next(1, 99);
        }

        return [firstNumber, secondNumber];
    }

    internal static bool CheckResult(int userInput, int expectedResult)
    {
        return userInput == expectedResult;
    }
    
    internal static string GetName()
    {
        Console.WriteLine("Please type your name:");

        var name = Console.ReadLine();
        while (string.IsNullOrEmpty(name)) {
            Console.WriteLine("Name cannot be empty.");
            name = Console.ReadLine();
        }

        return name;
    }
}
using MathGame.mickes27.Models;

namespace MathGame.mickes27;

internal class GameEngine
{
    internal void AdditionGame()
    {
        Console.Clear();
        Console.WriteLine("Addition game");

        var random = new Random();
        var score = 0;

        for (var i = 0; i < 5; ++i) {
            var firstNumber = random.Next(1, 10);
            var secondNumber = random.Next(1, 10);
            var expectedResult = firstNumber + secondNumber;

            Console.WriteLine($"{firstNumber} + {secondNumber}:");
            PlayGame(expectedResult, ref score);
        }

        FinishGame(score, GameType.Addition);
    }

    internal void SubtractionGame()
    {
        Console.Clear();
        Console.WriteLine("Subtraction game");

        var random = new Random();
        var score = 0;

        for (var i = 0; i < 5; ++i) {
            var firstNumber = random.Next(1, 10);
            var secondNumber = random.Next(1, 10);
            var expectedResult = firstNumber - secondNumber;

            Console.WriteLine($"{firstNumber} - {secondNumber}:");
            PlayGame(expectedResult, ref score);
        }

        FinishGame(score, GameType.Subtraction);
    }

    internal void MultiplicationGame()
    {
        Console.Clear();
        Console.WriteLine("Multiplication game.");

        var random = new Random();

        var score = 0;

        for (var i = 0; i < 5; ++i) {
            var firstNumber = random.Next(1, 10);
            var secondNumber = random.Next(1, 10);
            var expectedResult = firstNumber * secondNumber;

            Console.WriteLine($"{firstNumber} * {secondNumber}:");
            PlayGame(expectedResult, ref score);
        }

        FinishGame(score, GameType.Multiplication);
    }

    internal void DivisionGame()
    {
        Console.Clear();
        Console.WriteLine("Division game.");

        var score = 0;

        for (var i = 0; i < 5; ++i) {
            var randomNumbers = Helpers.GetDivisionNumbers();
            var firstNumber = randomNumbers[0];
            var secondNumber = randomNumbers[1];
            var expectedResult = firstNumber / secondNumber;

            Console.WriteLine($"{firstNumber} / {secondNumber}:");
            PlayGame(expectedResult, ref score);
        }

        FinishGame(score, GameType.Division);
    }

    private void PlayGame(int expectedResult, ref int score)
    {
        var userInput = GetUserInput();

        if (Helpers.CheckResult(userInput, expectedResult)) {
            Console.WriteLine("Your answer was correct. Type any key for next question.");
            ++score;
        } else {
            Console.WriteLine("Your answer was incorrect. Type any key for next question.");
        }

        Console.ReadKey();
    }

    private static int GetUserInput()
    {
        var userInput = Console.ReadLine();
        int parsedInput;
        
        while (string.IsNullOrEmpty(userInput) || !int.TryParse(userInput, out parsedInput)) {
            Console.WriteLine("Please enter a valid number.");
            userInput = Console.ReadLine();
        }

        return parsedInput;
    }

    private void FinishGame(int score, GameType gameType)
    {
        Console.WriteLine($"Your final score: {score}. Press any key to go back to Main Menu.");
        Helpers.AddToHistory(score, gameType);
        Console.ReadKey();
    }
}
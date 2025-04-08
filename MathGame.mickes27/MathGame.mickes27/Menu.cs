namespace MathGame.mickes27;

internal class Menu
{
    private readonly GameEngine gameEngine = new();

    internal void Show(string? name, DateTime date)
    {
        Console.WriteLine("----------------------------------------------------------------");
        Console.WriteLine($"Hello {name}. It's {date}. This is your math's game.");
        Console.WriteLine("Press any key to show menu.");
        Console.ReadKey();

        var isGameOn = true;

        do {
            Console.Clear();
            Console.WriteLine(@"What game would you like to play today? Choose from the options below:
                            A - Addition
                            S - Subtraction
                            M - Multiplication
                            D - Division
                            V - View Previous Games
                            Q - Quit");
            Console.WriteLine("----------------------------------------------------------------");

            var mode = Console.ReadLine()?.Trim().ToUpper();

            switch (mode) {
                case "A":
                    gameEngine.AdditionGame();
                    break;
                case "S":
                    gameEngine.SubtractionGame();
                    break;
                case "M":
                    gameEngine.MultiplicationGame();
                    break;
                case "D":
                    gameEngine.DivisionGame();
                    break;
                case "V":
                    Helpers.PrintGames();
                    break;
                case "Q":
                    Console.WriteLine("Goodbye.");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        } while (isGameOn);
    }
}
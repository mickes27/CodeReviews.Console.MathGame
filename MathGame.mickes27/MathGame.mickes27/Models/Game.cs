namespace MathGame.mickes27.Models;

internal class Game
{
    internal DateTime Date { get; init; }
    internal required GameType Type { get; init; }
    internal int Score { get; init; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}
namespace Branching.Tasks;

public class First
{
    private readonly string _startPoint;

    public First(string startPoint)
    {
        _startPoint = startPoint;
    }
    
    public string Solve(string point)
    {
        var letterDiff = Math.Abs(_startPoint[0] - point[0]);
        var numberDiff = Math.Abs(_startPoint[1] - point[1]);

        return $"From {_startPoint} to {point} is ok for:\n" +
               $"\tElephant : {IsStepForElephant(letterDiff, numberDiff)}\n" +
               $"\tHorse : {IsStepForHorse(letterDiff, numberDiff)}\n" +
               $"\tCastle : {IsStepForCastle(letterDiff, numberDiff)}\n" +
               $"\tQueen : {IsStepForQueen(letterDiff, numberDiff)}\n" +
               $"\tKing : {IsStepForKing(letterDiff, numberDiff)}\n";
    }

    private bool IsStepForElephant(int letterDiff, int numberDiff) => letterDiff == numberDiff;

    private bool IsStepForHorse(int letterDiff, int numberDiff)
    {
        return (letterDiff == 1 && numberDiff == 2)
               ^ (letterDiff == 2 && numberDiff == 1);
    }

    private bool IsStepForCastle(int letterDiff, int numberDiff) => (letterDiff == 0) ^ (numberDiff == 0);

    private bool IsStepForQueen(int letterDiff, int numberDiff) =>
        IsStepForElephant(letterDiff, numberDiff) ^ IsStepForCastle(letterDiff, numberDiff);

    private bool IsStepForKing(int letterDiff, int numberDiff)
    {
        return (IsStepForElephant(letterDiff, numberDiff) && letterDiff == 1)
               ^ (IsStepForCastle(letterDiff, numberDiff) && (letterDiff == 1 || numberDiff == 1));
    }
}
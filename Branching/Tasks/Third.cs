namespace Branching.Tasks;

public class Third
{
    private readonly int _ticketNumber;
    

    public Third(int ticketNumber)
    {
        _ticketNumber = ticketNumber;
    }

    public bool Solve()
    {
        var firstPart = _ticketNumber / 1000;
        var secondPart = _ticketNumber % 1000;

        var firstPartSum = GetSumOfPart(firstPart);
        
        var prevSecondPartSum = GetSumOfPart(secondPart - 1);
        var nextSecondPartSum = GetSumOfPart(secondPart + 1);

        return firstPartSum == prevSecondPartSum || firstPartSum == nextSecondPartSum;
    }

    private int GetSumOfPart(int ticketPart)
    {
        var result = 0;
        
        while (ticketPart > 0)
        {
            result += ticketPart % 10;
            ticketPart /= 10;
        }

        return result;
    }
}
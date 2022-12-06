namespace Branching.Tasks;

public class Fifth
{
    private readonly double _distanceToArea;
    private readonly double _segmentLength;
    private readonly int _segmentTime;

    public Fifth(double distanceToArea, double segmentLength, int segmentTime)
    {
        _distanceToArea = distanceToArea;
        _segmentLength = segmentLength;
        _segmentTime = segmentTime;
    }

    public (double, double) Solve()
    {
        var amountOfSegments = GetAmountOfSegments();
        return (Math.Floor(amountOfSegments), Math.Ceiling(amountOfSegments));
    }

    private double GetAmountOfSegments()
    {
        return _distanceToArea / _segmentLength;
    }
}
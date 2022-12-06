namespace Branching.Tasks;

public class Sixth
{
    private readonly (int, int) _firstPoint;
    private readonly (int, int) _secondPoint;
    private readonly (int, int) _thirdPoint;

    public Sixth((int, int) firstPoint, (int, int) secondPoint, (int, int) thirdPoint)
    {
        _firstPoint = firstPoint;
        _secondPoint = secondPoint;
        _thirdPoint = thirdPoint;
    }

    public (bool, (int, int)?) Solve()
    {
        var points = new[]
        {
            _firstPoint,
            _secondPoint,
            _thirdPoint
        };

        points = points
            .OrderBy(x => x.Item1)
            .ThenBy(x => x.Item2)
            .ToArray();
        
        (int, int)? fourthPoint = null;
        if (IsPointsOfSquare(points))
            fourthPoint = (points[0].Item1, points[2].Item2);

        return (IsPointsOfSquare(points), fourthPoint);
    }

    private static bool IsPointsOfSquare((int, int)[] points)
    {
        return points[0].Item2 == points[1].Item2 && points[0].Item1 == points[2].Item1;
    }
}
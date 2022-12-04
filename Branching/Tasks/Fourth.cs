namespace Branching.Tasks;

public class Fourth
{
    private readonly (int, int) _firstLine;
    private readonly (int, int) _secondLine;

    public Fourth((int, int) firstLine, (int, int) secondLine)
    {
        _firstLine = firstLine;
        _secondLine = secondLine;
    }

    public int Solve()
    {
        var lines = new[]
        {
            _firstLine,
            _secondLine
        };

        lines = lines
            .OrderBy(x => x.Item1)
            .ThenBy(x => x.Item2)
            .ToArray();

        if (lines[0].Item2 < lines[1].Item1)
            return 0;

        var startOfIntersection = Math.Max(lines[0].Item1, lines[1].Item1);
        var endOfIntersection = Math.Min(lines[0].Item2, lines[1].Item2);

        return endOfIntersection - startOfIntersection;
    }
}
using System.Security.Cryptography;

namespace Branching.Tasks;

public record Timber
{
    public int FirstSide { get; }
    public int SecondSide { get; }
    public int ThirdSide { get; }

    public Timber(int firstSide, int secondSide, int thirdSide)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }
}

public record Hole
{
    public int FirstSide { get; }
    public int SecondSide { get; }

    public Hole(int firstSide, int secondSide)
    {
        FirstSide = firstSide;
        SecondSide = secondSide;
    }
}

public class Second
{
    private readonly Timber _timber;
    private readonly Hole _hole;

    public Second(Timber timber, Hole hole)
    {
        _timber = timber;
        _hole = hole;
    }

    public bool Solve()
    {
        return (_timber.FirstSide <= _hole.FirstSide && _timber.SecondSide <= _hole.SecondSide)
               || (_timber.FirstSide <= _hole.FirstSide && _timber.ThirdSide <= _hole.SecondSide)
               || (_timber.SecondSide <= _hole.FirstSide && _timber.ThirdSide <= _hole.SecondSide);
    }
}
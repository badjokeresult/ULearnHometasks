namespace Branching.Tasks;

public class Seventh
{
    private readonly double _movieRating;
    private readonly int _reviewersCount;

    public Seventh(double movieRating, int reviewersCount)
    {
        _movieRating = movieRating;
        _reviewersCount = reviewersCount;
    }

    public int? Solve(double ratingDowngradeTo)
    {
        if (ratingDowngradeTo < 1 || ratingDowngradeTo >= 10)
            return null;

        var currentRating = _movieRating;
        var sumOfMarks = _reviewersCount * _movieRating;
        var reviewersCount = _reviewersCount;
        while (currentRating > ratingDowngradeTo)
        {
            sumOfMarks++;
            reviewersCount++;
            currentRating = sumOfMarks / reviewersCount;
        }

        return reviewersCount - _reviewersCount;
    }
}
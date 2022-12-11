namespace Loops.Tasks;

public class Fourth
{
    private readonly string _rawSequence;

    public Fourth(string rawSequence)
    {
        _rawSequence = rawSequence;
    }

    public int Solve()
    {
        var maxLength = 0;
        var currentLength = 0;

        var numArray = ToIntArray();

        for (int i = 1; i < numArray.Length; i++)
        {
            if (numArray[i] == numArray[i - 1])
            {
                currentLength++;
            }
            else
            {
                maxLength = Math.Max(maxLength, currentLength);
                currentLength = 0;
            }
        }

        maxLength = Math.Max(maxLength, currentLength);

        return maxLength;
    }

    private int[] ToIntArray()
    {
        var rawArray = _rawSequence.Split(' ');

        var intArray = new int[rawArray.Length];

        for (int i = 0; i < intArray.Length; i++)
            intArray[i] = int.Parse(rawArray[i]);

        return intArray;
    }
}
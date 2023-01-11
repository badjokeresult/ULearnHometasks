namespace CollectionsAndStringsAndFiles.Tasks;

public static class Fourth
{
    public static (int, int) Solve(int[] array, int windowSize)
    {
        var windowStart = 0;
        var windowEnd = windowSize - 1;
        var maxSum = int.MinValue;

        var maxStart = windowStart;
        var maxEnd = windowEnd;

        var currentSum = int.MinValue;
        while (windowEnd < array.Length)
        {
            for (int i = windowStart; i <= windowEnd; i++)
                currentSum += array[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxStart = windowStart;
                maxEnd = windowEnd;
            }

            currentSum = 0;
            windowStart++;
            windowEnd++;
        }

        return (maxStart, maxEnd);
    }
}
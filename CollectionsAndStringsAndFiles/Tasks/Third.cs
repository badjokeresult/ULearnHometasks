namespace CollectionsAndStringsAndFiles.Tasks;

public static class Third
{
    public static (int, int)? Solve(int[] array)
    {
        var sumArray = GetSumArray(array);

        var startIndex = Array.LastIndexOf(sumArray, 0);
        var endIndex = Array.IndexOf(sumArray, sumArray.Max());

        if (startIndex >= endIndex)
            return null;
        return (startIndex, endIndex);
    }

    private static int[] GetSumArray(int[] array)
    {
        var sumArray = new int[array.Length + 1];
        sumArray[0] = 0;

        for (int i = 1; i < array.Length + 1; i++)
            sumArray[i] = array[i - 1] + sumArray[i - 1];

        return sumArray;
    }
}
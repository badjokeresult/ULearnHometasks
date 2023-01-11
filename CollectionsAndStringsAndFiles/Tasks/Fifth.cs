namespace CollectionsAndStringsAndFiles.Tasks;

public static class Fifth
{
    public static bool Solve(int[] first, int[] second)
    {
        var indexOfFirst = 0;
        var lengthOfSubsequence = 0;

        for (int i = 0; i < second.Length; i++)
        {
            if (second[i] == first[indexOfFirst])
            {
                indexOfFirst++;
                lengthOfSubsequence++;
            }
            else
            {
                indexOfFirst = 0;
                lengthOfSubsequence = 0;
            }

            if (lengthOfSubsequence == first.Length)
                return true;
        }

        return false;
    }
}
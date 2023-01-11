namespace CollectionsAndStringsAndFiles.Tasks;

public static class Sixth
{
    public static Dictionary<(int, int), bool> Solve(int[] first, int[] second)
    {
        var result = new Dictionary<(int, int), bool>();
        var dct = new Dictionary<int, int>();

        for (int i = 0; i < second.Length - first.Length + 1; i++)
        {
            result[(i, first.Length + i)] = true;
            
            for (int j = i; j < first.Length + i; j++)
            {
                if (!dct.ContainsKey(second[j]))
                    dct[second[j]] = 0;
                dct[second[j]]++;
            }

            for (int j = 0; j < first.Length; j++)
            {
                if (!dct.ContainsKey(first[j]))
                {
                    result[(i, first.Length + i)] = false;
                    break;
                }
                dct[first[j]]--;
            }

            if (!IsEmptyDict(dct))
                result[(i, first.Length + i)] = false;
        }

        return result;
    }

    private static bool IsEmptyDict(Dictionary<int, int> dct)
    {
        foreach (var key in dct.Keys)
        {
            if (dct[key] > 0)
                return false;
        }

        return true;
    }
}
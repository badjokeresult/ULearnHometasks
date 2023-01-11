namespace CollectionsAndStringsAndFiles.Tasks;

public class First
{
    private readonly List<int> _scanners;

    public First(List<int> scanners)
    {
        _scanners = scanners;
    }

    public List<int> Solve(List<(int, int)> requests)
    {
        var preparedScanners = GetPreparedScanners();

        var result = new List<int>();
        
        foreach (var request in requests)
            result.Add(CountScannersValues(preparedScanners, request.Item1, request.Item2));

        return result;
    }

    private List<int> GetPreparedScanners()
    {
        var preparedScanners = new List<int>();
        preparedScanners.Add(0);
        
        for (int i = 0; i < _scanners.Count; i++)
            preparedScanners.Add(preparedScanners[i] + _scanners[i]);

        return preparedScanners;
    }

    private static int CountScannersValues(List<int> scanners, int left, int right) =>
        scanners[right] - scanners[left - 1];
}
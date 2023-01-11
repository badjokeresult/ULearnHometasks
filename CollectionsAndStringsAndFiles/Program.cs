using static System.Console;

using CollectionsAndStringsAndFiles.Tasks;

namespace CollectionsAndStringsAndFiles;

public static class Program
{
    public static void Main()
    {
        WriteLine("*** FIRST TASK ***");
        FirstTask();
        
        WriteLine("*** SECOND TASK ***");
        SecondTask();
        
        WriteLine("*** THIRD TASK ***");
        ThirdTask();
        
        WriteLine("*** FOURTH TASK ***");
        FourthTask();
        
        WriteLine("*** FIFTH TASK ***");
        FifthTask();
    }

    private static void FirstTask()
    {
        Write("\tEnter the amount of scanners: ");
        var amountOfScanners = int.Parse(ReadLine()!);

        var scanners = new List<int>();
        for (int i = 0; i < amountOfScanners; i++)
            scanners.Add(int.Parse(ReadLine()!));

        Write("\tEnter the amount of requests: ");
        var amountOfRequests = int.Parse(ReadLine()!);
        
        var requests = new List<(int, int)>();
        for (int i = 0; i < amountOfRequests; i++)
        {
            var request = ReadLine()!;
            var requestPair = request.Split(' ');
            
            requests.Add((int.Parse(requestPair.First()), int.Parse(requestPair.Last())));
        }

        var task = new First(scanners);
        var result = task.Solve(requests);
        
        foreach (var item in result)
            WriteLine($"\t{item}");
    }

    private static void SecondTask()
    {
        Write("\tEnter the amount of knights: ");
        var amountOfKnights = int.Parse(ReadLine()!);
        
        WriteLine("\tEnter the Artur's speeches: ");
        var speeches = new (int, int, int)[amountOfKnights + 1];

        for (int i = 0; i < speeches.Length; i++)
        {
            var data = ReadLine()!;
            var knights = data.Split(' ');
            speeches[i] = (int.Parse(knights[0]), int.Parse(knights[1]), int.Parse(knights[2]));
        }

        var task = new Second(amountOfKnights);
        var result = task.Solve(speeches);
        
        Write("\t");
        foreach (var item in result)
            Write($"{item} ");
    }

    private static void ThirdTask()
    {
        Write("\tEnter the length of an array: ");
        var len = int.Parse(ReadLine()!);

        var array = new int[len];
        for (int i = 0; i < len; i++)
        {
            Write($"\tEnter the value for index {i + 1}: ");
            array[i] = int.Parse(ReadLine()!);
        }

        var result = Third.Solve(array);
        if (result == null)
            WriteLine("\tNo data was found");
        else
            Write($"\t({result.Value.Item1}, {result.Value.Item2})");
    }

    private static void FourthTask()
    {
        Write("\tEnter the items of array through a space: ");
        var line = ReadLine()!;

        var splitted = line.Split(' ');
        var array = splitted
            .Select(x => int.Parse(x))
            .ToArray();
        
        Write("\tEnter the window size: ");
        var windowSize = int.Parse(ReadLine()!);

        var result = Fourth.Solve(array, windowSize);
        Write($"\tResult: ({result.Item1}, {result.Item2})");
    }

    private static void FifthTask()
    {
        Write("\tEnter the items of array through a space: ");
        var line = ReadLine()!;

        var splitted = line.Split(' ');
        var first = splitted
            .Select(x => int.Parse(x))
            .ToArray();
        
        Write("\tEnter the items of array through a space: ");
        line = ReadLine()!;

        splitted = line.Split(' ');
        var second = splitted
            .Select(x => int.Parse(x))
            .ToArray();
        
        Write($"\tResult: {Fifth.Solve(first, second)}");
    }

    private static void SixthTask()
    {
        Write("\tEnter the items of the array divided by a space: ");
        var line = ReadLine()!.Split(' ');
        var first = line
            .Select(x => int.Parse(x))
            .ToArray();
        
        Write("\tEnter the items of the array divided by a space: ");
        line = ReadLine()!.Split(' ');
        var second = line
            .Select(x => int.Parse(x))
            .ToArray();

        var result = Sixth.Solve(first, second);
        
        WriteLine("\tResult:");
        foreach (var key in result.Keys)
            WriteLine($"\t\t({key.Item1}, {key.Item2}) - {result[key]}");
    }
}
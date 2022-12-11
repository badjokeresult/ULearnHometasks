namespace Loops.Tasks;

public static class Third
{
    public static int Solve(int index)
    {
        var row = new List<int>();

        for (int i = 0; i < index; i++)
            AddDividedItem(row, i + 1);

        return row[index - 1];
    }

    private static void AddDividedItem(List<int> list, int item)
    {
        var items = new List<int>();

        while (item > 0)
        {
            items.Add(item % 10);
            item /= 10;
        }

        items.Reverse();
        
        list.AddRange(items);
    }
}
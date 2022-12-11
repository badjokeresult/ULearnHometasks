namespace Loops.Tasks;

public static class Second
{
    public static int Solve(int number)
    {
        var result = 0;

        for (int i = 1; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    if (i + j + k == number)
                    {
                        result++;
                        break;
                    }
                }
            }
        }

        return result;
    }
}
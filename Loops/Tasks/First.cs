namespace Loops.Tasks;

public static class First
{
    public static int Solve(int number)
    {
        if (number == 0)
            return 0;

        return ReversedNumber(number);
    }

    private static int LengthOfNumber(int number)
    {
        int checker = 10;
        int counter = 1;

        while (number / checker > 0)
        {
            counter++;
            checker *= 10;
        }

        return counter;
    }

    private static int ReversedNumber(int number)
    {
        var result = 0.0;

        var lengthOfNumber = LengthOfNumber(number);
        
        while (number > 0)
        {
            result += number % 10 * Math.Pow(10, lengthOfNumber--);
            number /= 10;
        }

        return (int)result;
    }
}
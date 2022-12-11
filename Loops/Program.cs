using System.Diagnostics;
using Loops.Tasks;
using static System.Console;

namespace Loops;

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
        Write("Enter the number to reverse: ");
        var number = int.Parse(ReadLine()!);
        
        WriteLine(First.Solve(number));
    }

    private static void SecondTask()
    {
        Write("Enter the number: ");
        var number = int.Parse(ReadLine()!);
        
        WriteLine(Second.Solve(number));
    }

    private static void ThirdTask()
    {
        Write("Enter the index of the number: ");
        var index = int.Parse(ReadLine()!);
        
        WriteLine(Third.Solve(index));
    }

    private static void FourthTask()
    {
        Write("Enter the numbers of an array through a space: ");
        var nums = ReadLine()!;

        var task = new Fourth(nums);
        WriteLine(task.Solve());
    }

    private static void FifthTask()
    {
        Write("Enter the sequence of parentheses: ");
        var parentheses = ReadLine()!;

        var task = new Fifth();
        WriteLine(task.Solve(parentheses));
    }
}

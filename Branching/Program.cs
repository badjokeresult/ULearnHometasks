using static System.Console;

using Branching.Tasks;

namespace Branching;

public class Program
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
    }

    private static void FirstTask()
    {
        Write("Enter the start point: ");
        var startPoint = ReadLine();
        
        Write("Enter the end point: ");
        var endPoint = ReadLine();
        
        var task = new First(startPoint!);
        
        WriteLine(task.Solve(endPoint!));
    }

    private static void SecondTask()
    {
        WriteLine("Enter the sides og the timber (x, y, z):");
        var x = int.Parse(ReadLine()!);
        var y = int.Parse(ReadLine()!);
        var z = int.Parse(ReadLine()!);
        var timber = new Timber(x, y, z);
        
        WriteLine("Enter the sides of the hole:");
        var a = int.Parse(ReadLine()!);
        var b = int.Parse(ReadLine()!);
        var hole = new Hole(a, b);

        var task = new Second(timber, hole);
        
        WriteLine(task.Solve());
    }

    private static void ThirdTask()
    {
        Write("Enter the current ticket number: ");
        var ticketNumber = int.Parse(ReadLine()!);

        var task = new Third(ticketNumber);
        
        WriteLine(task.Solve());
    }

    private static void FourthTask()
    {
        WriteLine("Enter the points of lines:");
        
        Write("\tA: ");
        var a = int.Parse(ReadLine()!);
        Write("\tB: ");
        var b = int.Parse(ReadLine()!);
        
        Write("\tC: ");
        var c = int.Parse(ReadLine()!);
        Write("\tD: ");
        var d = int.Parse(ReadLine()!);

        var firstLine = (a, b);
        var secondLine = (c, d);

        var task = new Fourth(firstLine, secondLine);
        WriteLine(task.Solve());
    }
}
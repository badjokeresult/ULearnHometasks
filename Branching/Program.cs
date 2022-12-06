using static System.Console;

using Branching.Tasks;

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

WriteLine("*** SIXTH TASK ***");
SixthTask();

WriteLine("*** SEVENTH TASK ***");
SeventhTask();


void FirstTask()
{
    Write("Enter the start point: ");
    var startPoint = ReadLine();

    Write("Enter the end point: ");
    var endPoint = ReadLine();

    var task = new First(startPoint!);

    WriteLine(task.Solve(endPoint!));
}

void SecondTask()
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

void ThirdTask()
{
    Write("Enter the current ticket number: ");
    var ticketNumber = int.Parse(ReadLine()!);

    var task = new Third(ticketNumber);

    WriteLine(task.Solve());
}

void FourthTask()
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

void FifthTask()
{
    WriteLine("Enter the distance to area, length of segment and time to overcome a segment divided by spaces:");
    var data = ReadLine()!;

    var arrayedData = data.Split(' ');
    var distanceToArea = double.Parse(arrayedData[0]);
    var segmentLength = double.Parse(arrayedData[1]);
    var segmentTime = int.Parse(arrayedData[2]);

    var task = new Fifth(distanceToArea, segmentLength, segmentTime);
    WriteLine(task.Solve());
}

void SixthTask()
{
    WriteLine("Enter the first point:");

    Write("\tA: ");
    var a = int.Parse(ReadLine()!);
    Write("\tB: ");
    var b = int.Parse(ReadLine()!);

    var firstPoint = (a, b);

    WriteLine("Enter the second point:");

    Write("\tA: ");
    a = int.Parse(ReadLine()!);
    Write("\tB: ");
    b = int.Parse(ReadLine()!);

    var secondPoint = (a, b);

    WriteLine("Enter the third point:");

    Write("\tA: ");
    a = int.Parse(ReadLine()!);
    Write("\tB: ");
    b = int.Parse(ReadLine()!);

    var thirdPoint = (a, b);

    var task = new Sixth(firstPoint, secondPoint, thirdPoint);
    WriteLine(task.Solve());
}

void SeventhTask()
{
    WriteLine("Enter the movie rating, rating downgrade to and amount of reviewers:");
    var data = ReadLine()!;

    var arrayedData = data.Split(' ');
    var movieRating = double.Parse(arrayedData[0]);
    var ratingDowngradeTo = double.Parse(arrayedData[1]);
    var reviewersCount = int.Parse(arrayedData[2]);

    var task = new Seventh(movieRating, reviewersCount);
    WriteLine(task.Solve(ratingDowngradeTo));
}
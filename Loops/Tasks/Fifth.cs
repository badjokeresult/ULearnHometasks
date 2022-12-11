namespace Loops.Tasks;

public class Fifth
{
    private readonly Stack<char> _stack;

    public Fifth()
    {
        _stack = new Stack<char>();
    }

    public (bool, int) Solve(string parentheses)
    {
        var isCorrect = true;
        var maxDepth = 0;

        foreach (var p in parentheses)
        {
            if (p == '(')
            {
                _stack.Push(p);
            }
            else
            {
                var result = '\0';

                if (_stack.TryPop(out result))
                    maxDepth = Math.Max(maxDepth, _stack.Count + 1);
                else
                    break;
            }
        }

        if (_stack.Count != 0)
            isCorrect = false;

        return (isCorrect, maxDepth);
    }
}
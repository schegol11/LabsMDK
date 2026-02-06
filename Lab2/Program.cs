// Задание 1.38

LongLong longlonglong = new();

longlonglong.longlong.Item1 = 2;
longlonglong.longlong.Item2 = 3;

Operations calc = new();

calc.Operation((int)longlonglong.longlong.Item1, (int)longlonglong.longlong.Item2, (int)longlonglong.longlong.Item2, (int)longlonglong.longlong.Item1, (int)longlonglong.longlong.Item2);
calc.Operation((int)longlonglong.longlong.Item1, (int)longlonglong.longlong.Item2, (int)longlonglong.longlong.Item1, (int)longlonglong.longlong.Item2);
calc.Operation((int)longlonglong.longlong.Item1, (int)longlonglong.longlong.Item2, (int)longlonglong.longlong.Item2);
calc.Operation((int)longlonglong.longlong.Item1, (int)longlonglong.longlong.Item2);


public class LongLong()
{
    public (long, long) longlong;
}

class Operations
{
    public void Operation(int a, int b)
    {
        var result = a / b;
        Console.WriteLine(result);
    }

    public void Operation(int a, int b, int c)
    {
        var result = a * b * c;
        Console.WriteLine(result);
    }
    public void Operation(int a, int b, int c, int d)
    {
        var result = a - b - c - d;
        Console.WriteLine(result);
    }
    public void Operation(int a, int b, int c, int d, int e)
    {
        var result = a + b + c + d + e;
        Console.WriteLine(result);
    }
}

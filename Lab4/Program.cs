int maxTrains = 6;
Train[] trains = new Train[maxTrains];

for (int i = 0; i < maxTrains; i++)
{
    Console.WriteLine("------------");
    Console.WriteLine($"Поезд {i + 1}/{maxTrains}");

    Console.Write("Введите пункт назначения: ");
    string endPoint = Console.ReadLine()!;

    Console.Write("Введите номер: ");
    int number = int.Parse(Console.ReadLine()!);

    Console.Write("Введите номер: ");
    DateTime startTime = DateTime.Parse(Console.ReadLine()!);

    Console.WriteLine("------------");
    Console.WriteLine();

    if (i > 0 && trains[i - 1] != null)
    {
        var targetTrain = trains[i - 1];
        trains[i] = (Train)targetTrain.Clone();

        targetTrain.endPoint = endPoint;
        targetTrain.number = number;
        targetTrain.startTime = startTime;
    }
    else trains[i] = new Train(endPoint, number, startTime);
}

Console.WriteLine();

Console.WriteLine("------------");
Array.Sort(trains, new TrainCompareByEndPoint());
foreach (var train in trains) Console.WriteLine(train);
Console.WriteLine("------------");

Console.Write("Введите пункт назначения: ");
string endPointFinal = Console.ReadLine()!;

foreach (var train in trains) if (train.endPoint == endPointFinal) Console.WriteLine(train);

class Train(string endPoint, int number, DateTime startTime) : ICloneable, IComparable
{
    public string endPoint = endPoint;
    public int number = number;
    public DateTime startTime = startTime;

    public override string ToString() => $"Пункт назначения: {endPoint}, Номер: {number}, дата отправки: {startTime}";
    public object Clone() => new Train(endPoint, number, startTime);
    public int CompareTo(object? obj)
    {
        if (obj is Train train) return startTime.CompareTo(train.startTime);
        else throw new ArgumentException("ZV");
    }
}

class TrainCompareByEndPoint() : IComparer<Train>
{
    public int Compare(Train? x, Train? y)
    {
        if (x is null || y is null) throw new ArgumentException("ZV");
        return x.endPoint.CompareTo(y.endPoint);
    }
}

//Задание 74

Decimal dec = new();

Console.WriteLine(dec.Compute());
dec.Print();

Binary bin = new();

Console.WriteLine(bin.Compute());
bin.Print();

interface Integer
{

    public int Compute();

    public void Print();
}

public class Decimal : Integer
{
    public decimal[] decimalArray = { 1,1, 2,2, 3,3};

    public int Compute()
    {
        int decResult = 0;
        foreach (var dec in decimalArray) decResult += (int)dec;

        return decResult;
    }

    public void Print() => Console.WriteLine("Курага");
}

public class Binary : Integer
{
    public int[] binaryArray = { 1, 0, 1, 0, 1 };

    public int Compute()
    {
        int binResult = 0;
        foreach (var bin in binaryArray)
        {
            binResult *= 10;
            if (bin == 1) binResult += 1;
        }
        return binResult;
    }

    public void Print() => Console.WriteLine("Егор");
}

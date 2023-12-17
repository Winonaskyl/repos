using System;
class F
{
    public int CalcFib(int n)
    {
        if (n <= 1)
            return n;

        return CalcFib(n - 1) + CalcFib(n - 2);
    }
}

class Program
{
    static void Main()
    {
        F number = new F();

        int result1 = number.CalcFib(2);
        Console.WriteLine($"Input: n = 2\nOutput: {result1}");
        int result2 = number.CalcFib(3);
        Console.WriteLine($"Input: n = 3\nOutput: {result2}");
        int result3 = number.CalcFib(4);
        Console.WriteLine($"Input: n = 4\nOutput: {result3}");
    }
}

class Program
{
    static void ReverseString(string a)
    {
        if (a.Length == 0)
        {  
            return;
        }
        else
        {
            Console.Write(a[a.Length - 1]);
            ReverseString(a.Substring(0, a.Length - 1));
        }
    }

    static void Main()
    {
        string inputString = "tiger";
        ReverseString(inputString);
    }
}
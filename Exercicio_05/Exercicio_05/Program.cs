class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(reverseString("!kO tseT"));
    }

    static string reverseString(string str)
    {
        string reversedStr = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedStr += str[i];
        }
        return reversedStr;
    }
}
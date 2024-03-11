class Program
{
    static void Main(String[] args)
    {
        Console.Write("Informe um número: ");
        int n = int.Parse(Console.ReadLine());
        if (isFibonacci(n))
        {
            Console.WriteLine($"O número {n} pertence a sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {n} NÃO pertence a sequência de Fibonacci.");
        }
    }

    static public bool isFibonacci(int n)
    {
        int a = 0;
        int b = 1;
        int i = 0;

        while (i <= n)
        {

            if (i == n)
            {
                return true;
            }

            i = a + b;
            a = b;
            b = i;
        }
        return false;
    }
}
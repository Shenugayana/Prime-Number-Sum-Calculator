public class Program
{
    public static void Main()
    {
        int x = 29;
        int sum = 0;

        for(int i = x; i > 0; i--)
        {
            int div = 0;
            for (int j = i; j > 0; j--)
            {
                if (i % j == 0) div++; 
            }
            if (div == 2) sum = sum + i;
        }
        Console.WriteLine("Sum of Prime numbers below X: " + sum);
    }
}

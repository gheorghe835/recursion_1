internal class Program
{
    //Task 2: Write a programme for calculating the 
    //Ackerman function using recursion. 
    //Two non-negative numbers m and n are given.
    static void Main()
    {
        int m = 2; // example of value m
        int n = 3; // example of value n

        int result = AckermannFunction(m, n);
        Console.WriteLine($"The result of the Ackerman function  for m = {m} and n = {n} is {result}");
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}
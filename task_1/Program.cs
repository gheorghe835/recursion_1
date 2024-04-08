internal class Program
{
    //Task 1: Set the values of M and N. 
    //Write a programme that outputs all 
    //natural numbers in the interval from M to N. 
    //Use recursion, do not use loops.
    
    static void Main()
    {
        int M = 4; // initial value M
        int N = 8; // final value N

        PrintNumbersInRange(M, N);
    }

    static void PrintNumbersInRange(int current, int end)
    {
        if (current <= end)
        {
            Console.WriteLine(current);
            PrintNumbersInRange(current + 1, end);
        }
    }
}

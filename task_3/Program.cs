internal class Program
{
    //   Task 3: Define an arbitrary array. 
    //Output its elements starting from the end. 
    //Use recursion, do not use loops.

    static void Main()
    {
        int[] array = { 1, 2, 5, 0, 10, 34 }; // Arbitrary array

        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintArrayReversed(arr, index - 1);
        }
    }
}

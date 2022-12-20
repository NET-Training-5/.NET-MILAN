//Parallel Programming
using System;
using System.Threading;
using System.Threading.Tasks;
class ParallelAndAsync
{
    public void WriteParallelCode()
    {
           // Sequential Loop
        Console.WriteLine("Sequential: ");

        for (byte i = 1; i < 11; i++)
        {

            DoTask(i);
        }

        // Parallel loop
        Console.WriteLine("Parallel: ");
        Parallel.For(1, 11, i => DoTask(i));
    }

    void DoTask(int counter)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Doone with task {counter}");
    }

    public void isPrimeOrNot()
    {
    long[] numbers = {66778910,5262628, 26282828, 3215, 7523, 8970, 526267, 5262762, 526261, 11111111, 6262728, 5541314, 6677171, 667771, 234511, 627811, 3141415, 6617187,978801, 877810};
    foreach (var item in numbers)
    {
        Console.WriteLine("Sequential: ");
        var p = isPrime(item) ? "Prime" : "Composite";
        Console.WriteLine($"{item} is {p}");  
    }
    Console.WriteLine("Parallel: ");
    Parallel.ForEach(numbers, (item) =>
    {
        var p = isPrime(item) ? "Prime" : "Composite";
        Console.WriteLine($"{item} is {p}");  
    });
     bool isPrime(long n)          //Method to check prime numbers
    {
    Thread.Sleep(500);
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
    }
    }
}
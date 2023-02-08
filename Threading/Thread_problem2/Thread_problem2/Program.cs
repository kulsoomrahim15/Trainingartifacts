
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int numbersToPrint = 100;
        int numberOfThreads = 10;
        int numbersPerThread = numbersToPrint / numberOfThreads;

        for (int i = 0; i < numberOfThreads; i++)
        {// each thread has to print 10 nos.
            int start = i * numbersPerThread + 1;
            int end = start + numbersPerThread - 1;
            Thread thread = new Thread(() => PrintNumbers(start, end));
            thread.Start();
        }
    }

    static void PrintNumbers(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(i + " printed by Thread : " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}

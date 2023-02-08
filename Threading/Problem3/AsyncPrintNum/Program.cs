using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPrintNum
{
  
    public delegate void AsyncMethodCaller(int strat, int end, int threadId);
    class Program
    {


        static void Main(string[] args)
        {
            AsyncMethodCaller caller = new AsyncMethodCaller(PrintNumbers);
            int threadid = 0;




            int numbersToPrint = 100;
            int numberOfThreads = 10;
            int numbersPerThread = numbersToPrint / numberOfThreads;




            for (int i = 0; i < numberOfThreads; i++)
            {// each thread has to print 10 nos.
                int start = i * numbersPerThread + 1;
                int end = start + numbersPerThread - 1;
                //Thread thread = new Thread(() => PrintNumbers(start, end));
                // thread.Start();
                threadid++;

                var workTask = Task.Run(() => caller.Invoke(start, end, threadid));
                //Console.WriteLine("control is back !");
            }
            //IAsyncResult result = caller.BeginInvoke(3000, out threadid, null, null);




            //string res = caller.EndInvoke(out threadid, result);
            //      string res = workTask.Result;

            Console.WriteLine("Completed!");
            //     Console.WriteLine(res);
            Console.Read();
        }
      




        static void PrintNumbers(int start, int end, int threadNo)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i + " printed by Thread : " + threadNo);
            }
            
        }
    }
}
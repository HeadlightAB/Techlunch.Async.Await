using System;
using System.Threading;

namespace Example_1
{
    public class WorkerDemo
    {
        public static void RunWorkerDemo()
        {
            Console.WriteLine("Starting worker");

            var worker = new Worker();

            worker.DoWork();

            while (!worker.IsComplete)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Worker done");
        }

        public class Worker
        {
            public bool IsComplete { get; private set; }

            public void DoWork()
            {
                IsComplete = false;
                Console.WriteLine("Doing work");

                LongOperation();

                Console.WriteLine("Work completed");

                IsComplete = true;
            }

            private void LongOperation()
            {
                Console.WriteLine("Working!");
                Thread.Sleep(2000);
            }
        }
    }
}

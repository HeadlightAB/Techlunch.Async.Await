using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example_1
{
    public class ModifiedWorkerDemo
    {
        public static void RunModifiedWorkerDemo()
        {
            Console.WriteLine("Starting modified worker");

            var modifiedWorker = new ModifiedWorker();

            modifiedWorker.DoWork();

            while (!modifiedWorker.IsComplete)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            Console.WriteLine("Modified worker done");
        }

        public class ModifiedWorker
        {
            public bool IsComplete { get; private set; }

            public async void DoWork()
            {
                IsComplete = false;
                Console.WriteLine("Doing work");

                await LongOperation();

                Console.WriteLine();
                Console.WriteLine("Work completed");

                IsComplete = true;
            }

            private Task LongOperation()
            {
                return Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Working!");
                    Thread.Sleep(2000);
                });
            }
        }
    }
}
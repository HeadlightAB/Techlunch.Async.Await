using System;
using System.Threading;
using System.Threading.Tasks;

namespace Extra_Example
{
    public class TaskAfterTaskExceptionDemo
    {
        private static Func<Task, int> continuationFunc = incomingTask => throw new AbandonedMutexException("Ist heute Kartoffelpüree Tag?");

        private static Func<Task<int>, int> secondContinuationFunc = incomingTask =>
        {
            //var result = incomingTask.GetAwaiter().GetResult(); // The exception in "previous task" is propagated
            
            //var result = incomingTask.Result; // The exception in incoming is wrapped in AggregateException
            
            //incomingTask.Wait(); // Waiting for the incoming to complete wraps the exception in AggregateException

            // Not doing anything with the incoming hides the exception thrown in that task
            throw new AbandonedMutexException("Nein, Kartoffeln sollten ungebrochen gegessen werden!");
        };

        public static void RunDemo()
        {
            var firstTask = Task.Run(() => {});
            var secondTask = firstTask.ContinueWith(continuationFunc).ContinueWith(secondContinuationFunc);

            try
            {
                var result = secondTask.GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
            }
        }
    }
}
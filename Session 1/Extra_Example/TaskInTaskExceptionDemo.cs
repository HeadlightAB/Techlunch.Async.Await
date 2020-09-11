using System;
using System.Threading;
using System.Threading.Tasks;

namespace Extra_Example
{
    ////////////////////////////////////////////////////////////////////
    // One scenario, three different ways handling the task in task
    // 1. Do nothing, hang around for a second and see what happens.
    // 2. Do the .Wait-thing.
    // 3. .GetAwaiter().GetResult
    ////////////////////////////////////////////////////////////////////
    
    public class TaskInTaskExceptionDemo
    {
        private static Action act = () => throw new AbandonedMutexException("Ist heute Kartoffeltag?");

        private static Func<int> func = () =>
        {
            var task = Task.Run(act);

            // Handling # 1 -> Exception is hidden
            //Task.Delay(1000).GetAwaiter().GetResult();

            // Handling # 2 -> Exception wrapped in AggregateException
            //task.Wait();

            // handling # 3 -> Exception propagates
            //task.GetAwaiter().GetResult();
            

            return 0;
        };
        
        public static void RunDemo()
        {
            var task = Task.Run(func);

            try
            {
                var result = task.GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
            }
        }
    }
}
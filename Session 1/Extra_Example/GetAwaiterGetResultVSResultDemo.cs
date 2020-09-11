using System;
using System.Runtime;
using System.Threading;
using System.Threading.Tasks;

namespace Extra_Example
{
    public class GetAwaiterGetResultVSResultDemo
    {
        private static Func<int> func = () => throw new AbandonedMutexException("Danke gut! Und wie geht's Ihnen?");

        private static Action act () => throw new AmbiguousImplementationException("Ich sehe doppelt");

        public static void RunDemo()
        {
            var task1 = Task.Run(func);
            try
            {
                var result = task1.Result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            ////////////////////////////////

            var task2 = Task.Run(func);
            try
            {
                var result = task2.GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            //****************************
            //****************************
            //****************************

            try
            {
                var task3 = Task.Run(act());

                task3.Wait();
                //var result = task3.Result;
                //task3.GetAwaiter().GetResult();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
            }

            //////////////////////////////////

        }
    }

    //GetAwaiterGetResultVSResultDemo.RunDemo();
}

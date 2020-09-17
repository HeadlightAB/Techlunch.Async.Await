using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Example_2_ValueTask
{
    public class Program
    {
        static void Main()
        {
            var a = GetNumber();
            Console.WriteLine(a.GetAwaiter().GetResult());

            var b = GetValue();
            Console.WriteLine(b.GetAwaiter().GetResult());

            Console.WriteLine();

            ///////////////////////////////////////////////////////////


            Console.WriteLine("Hit [ENTER] to go with task");
            Console.ReadLine();
            _taskCount = 0;

            var stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < 100_000; i++)
            {
                GetNumber().GetAwaiter().GetResult();
            }
            stopwatch.Stop();

            Console.WriteLine($"Elapsed: {stopwatch.Elapsed} (count: {_taskCount})");
            Console.WriteLine();


            ///////////////////////////////////////////////////////////


            Console.WriteLine("Hit [ENTER] to go with ValueTask");
            Console.ReadLine();
            _valueTaskCount = 0;

            stopwatch = Stopwatch.StartNew();
            for (var i = 0; i < 100_000; i++)
            {
                GetValue().GetAwaiter().GetResult();
            }
            stopwatch.Stop();

            Console.WriteLine($"Elapsed: {stopwatch.Elapsed} (count: {_valueTaskCount})");
            Console.WriteLine();


            ///////////////////////////////////////////////////////////


            //Console.WriteLine("Hit [ENTER] to go with ValueTask, but with AsTask");
            //Console.ReadLine();
            //_valueTaskCount = 0;

            //stopwatch = Stopwatch.StartNew();
            //for (var i = 0; i < 100_000; i++)
            //{
            //    GetValue().AsTask().GetAwaiter().GetResult();
            //}
            //stopwatch.Stop();

            //Console.WriteLine($"Elapsed: {stopwatch.Elapsed} (count: {_valueTaskCount})");
        }

        private static int _taskCount;
        private static int _valueTaskCount;

        private static async Task<int> GetNumber()
        {
            _taskCount++;

            return await Task.Run(() => new Random().Next(int.MaxValue));
        }

        private static async ValueTask<int> GetValue()
        {
            _valueTaskCount++;

            return await new ValueTask<int>(new Random().Next(int.MaxValue));
        }
    }
}

using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Example_3
{
    class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Do things asynchronously, long busy wait => same thread id");
            Console.WriteLine("==========================================================");
            ///////////////////////
            await DoThings(longBusyWait: true);
            ///////////////////////

            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("Press [ENTER] to continue");
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Do things asynchronously, short busy wait => multiple thread ids");
            Console.WriteLine("================================================================");
            ///////////////////////
            await DoThings(longBusyWait: false);
            ///////////////////////
        }

        private static async Task DoThings(bool longBusyWait)
        {
            Thread.CurrentThread.ManagedThreadId.Dump("1");
            var client = new HttpClient();
            Thread.CurrentThread.ManagedThreadId.Dump("2");
            var task = client.GetStringAsync("http://google.com");
            Thread.CurrentThread.ManagedThreadId.Dump("3");

            var a = 0;
            for (int i = 0; i < 1_000 * (longBusyWait ? 100_000 : 1); i++)
            {
                a += i;
            }

            Thread.CurrentThread.ManagedThreadId.Dump("4");
            var page = await task;
            Thread.CurrentThread.ManagedThreadId.Dump("5");
        }
    }

    public static class IntExtensions
    {
        public static void Dump(this object threadId, string trace)
        {
            Console.WriteLine($"|{trace}{Environment.NewLine}|thread id: {threadId}{Environment.NewLine}");
        }
    }
}

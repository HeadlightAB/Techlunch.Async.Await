using System;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Making tea synchronously");
            Console.WriteLine("========================");
            ///////////////////////
            MakeTea();
            ///////////////////////

            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("Press [ENTER] to continue");
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Making tea asynchronously, no busy wait");
            Console.WriteLine("=======================================");
            ///////////////////////
            await MakeTeaAsync(busyWait: false);
            ///////////////////////
            
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("Press [ENTER] to continue");
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Making tea asynchronously, busy wait");
            Console.WriteLine("====================================");
            ///////////////////////
            await MakeTeaAsync(busyWait: true);
            ///////////////////////

            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine("Press [ENTER] to exit");
            Console.ReadLine();
        }

        public static string MakeTea()
        {
            var water = BoilWater();

            "take the cups out".Dump();

            "put tea in cups".Dump();

            var tea = $"pour {water} in cups".Dump();

            return tea;
        }
        
        public static string BoilWater()
        {
            "Start the kettle".Dump();

            "waiting for the kettle".Dump();
            Task.Delay(2000).GetAwaiter().GetResult();

            "kettle finished boiling".Dump();

            return "water";
        }

        public static async Task<string> MakeTeaAsync(bool busyWait = false)
        {
            var boilingWater = BoilWaterAsync(busyWait ? 300 : 2000);

            "take the cups out".Dump();

            if (busyWait)
            {
                var a = 0;
                for (int i = 0; i < 100_000_000; i++)
                {
                    a += i;
                }
            }

            "put tea in cups".Dump();

            var water = await boilingWater;

            var tea = $"pour {water} in cups".Dump();

            return tea;
        }

        public static async Task<string> BoilWaterAsync(int kettleDelay)
        {
            "Start the kettle".Dump();

            "waiting for the kettle".Dump();
            await Task.Delay(kettleDelay);

            "kettle finished boiling".Dump();

            return "water";
        }
    }

    public static class StringExtensions 
    {
        public static string Dump(this string value)
        {
            Console.WriteLine(value);

            return value;
        }
    }
}

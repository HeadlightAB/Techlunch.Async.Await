using System;

namespace Example_1
{
	public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Running worker demo");
            Console.WriteLine("===================");
            Console.WriteLine();
            
            ///////////////////////
            WorkerDemo.RunWorkerDemo();
            ///////////////////////

            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("Press [ENTER] to continue");
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Running modified worker demo");
            Console.WriteLine("============================");
            Console.WriteLine();

            ///////////////////////
            ModifiedWorkerDemo.RunModifiedWorkerDemo();
            ///////////////////////
            
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine("Press [ENTER] to exit");
            Console.ReadLine();
        }
    }
}

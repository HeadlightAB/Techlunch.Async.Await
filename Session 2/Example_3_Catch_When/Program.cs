using System;

namespace Example_3_Catch_When
{
    public class Program
    {
        static void Main()
        {
            for (var i = 0; i < 25; i++)
            {
                try
                {
                    throw new IntegrationException(i);
                }
                catch (IntegrationException e) when (e.Status < 10)
                {
                    Console.WriteLine($"{e.Status} - Schade, zu viel!");
                }
                catch (IntegrationException e) when (e.Status > 9 && e.Status < 20)
                {
                    Console.WriteLine($"{e.Status} - Schade, immer zu viel!");
                }
                catch (IntegrationException e)
                {
                    Console.WriteLine($"{e.Status} - Ich gebe auf...");
                }
            }
        }
    }

    public class IntegrationException : Exception
    {
        public int Status { get; set; }

        public IntegrationException(int status)
        {
            Status = status;
        }
    }
}

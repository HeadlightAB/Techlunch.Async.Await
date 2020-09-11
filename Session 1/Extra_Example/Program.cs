﻿using System.Threading.Tasks;

namespace Extra_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////
            // Method signature 'async Task ...'

            //AsyncAndExceptionsDemo.RunDemo1();
            //Task.Delay(1000).GetAwaiter().GetResult();


            ////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////
            // Method signature 'async void ...'

            //AsyncAndExceptionsDemo.RunDemo2();
            //Task.Delay(1000).GetAwaiter().GetResult();


            ////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////
            // Three tasks handled differently, .Result, .GetAwaiter().GetResult, .Wait()

            //GetAwaiterGetResultVSResultDemo.RunDemo();
            //Task.Delay(1000).GetAwaiter().GetResult();


            ////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////
            // Task gets started INSIDE another task

            //TaskInTaskExceptionDemo.RunDemo();
            //Task.Delay(1000).GetAwaiter().GetResult();


            ////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////
            // Task gets started AFTER another task, using .ContinueWith(...)

            //TaskAfterTaskExceptionDemo.RunDemo();
            //Task.Delay(1000).GetAwaiter().GetResult();
        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_1_ConfigureAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonConfigureAwaitTrueAkaDefault_Click(object sender, EventArgs e)
        {
            await WriteRandomIntegers();

            Console.WriteLine();
            Console.WriteLine($"Done... @ ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine();
        }

        private async void buttonConfigureAwaitFalse_Click(object sender, EventArgs e)
        {
            await WriteRandomIntegersConfigureAwaitFalse();

            Console.WriteLine();
            Console.WriteLine($"Done... @ ThreadId: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine();
        }

        private static async Task WriteRandomIntegers()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Creating integer {i}   @ ThreadId: {Thread.CurrentThread.ManagedThreadId}");
                await Task.Delay(100);

                var next = new Random().Next(99999999);

                Console.WriteLine($"integer {i} - {string.Format("{0,8:D}", next)} @ ThreadId: {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine();
            }
        }

        private static async Task WriteRandomIntegersConfigureAwaitFalse()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Creating integer {i}   @ ThreadId: {Thread.CurrentThread.ManagedThreadId}");
                await Task.Delay(100).ConfigureAwait(false);

                var next = new Random().Next(99999999);

                Console.WriteLine($"integer {i} - {string.Format("{0,8:D}", next)} @ ThreadId: {Thread.CurrentThread.ManagedThreadId}");
                Console.WriteLine();
            }
        }
    }
}

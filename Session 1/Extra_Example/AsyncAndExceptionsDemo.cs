using System.Threading;
using System.Threading.Tasks;

namespace Extra_Example
{
    public class AsyncAndExceptionsDemo
    {
        public static async Task RunDemo1()
        {
            await MethodThrowingException();
        }

        public static async void RunDemo2()
        {
            await MethodThrowingException();
        }

        private static async Task MethodThrowingException()
        {
            throw new AbandonedMutexException("Hallo Dieter, wie geht's?");
        }
    }
}

using System.Reflection.Emit;

namespace ConsoleApp4
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("Main Method Started......");
            Console.WriteLine("Main Method Thread 1- ["+ System.Environment.CurrentManagedThreadId + "]");

            var task = SomeMethod();
            Console.WriteLine("Main Method Thread 2- [" + System.Environment.CurrentManagedThreadId + "]");
            Console.WriteLine("Main Method End");
            string Result = task.Result;
            Console.WriteLine($"Result : {Result}" +" - [" +System.Environment.CurrentManagedThreadId + "]");
            Console.WriteLine("Program End");
            Console.ReadKey();
        }

        public static async Task<string> SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            Console.WriteLine("Main Method Thread 3- [" + System.Environment.CurrentManagedThreadId + "]");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine("\n");
            Console.WriteLine("Main Method Thread 4- [" + System.Environment.CurrentManagedThreadId + "]");
            Console.WriteLine("Some Method End- [" + System.Environment.CurrentManagedThreadId + "]");
            return "Some Data";

        }

    }
}
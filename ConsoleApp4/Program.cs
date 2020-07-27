using System;
using System.Security;

[assembly: AllowPartiallyTrustedCallers]

namespace ConsoleApp4
{
    class Program
    {
        static object[] items = new object[] { 1, 2, 3 };

        static void Main(string[] args)
        {
            var result = GetResults(new ComparisonState());

            Console.WriteLine($"Result = {result}");

            Console.ReadKey();
        }

        private static bool GetResults(ComparisonState state)
        {
            var newState = state
                .PushComparison(items[0], items[1])
                .PushComparison(items[1], items[2]);

            var result = newState.DidCompare(items[0], items[1]);
            return result;
        }
    }
}

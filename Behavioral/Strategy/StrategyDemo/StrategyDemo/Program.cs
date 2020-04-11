using StrategyDemo.Strategies;
using System;

namespace StrategyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bootstrapper = new Bootstrapper();
            var numbers = new int[] { 5, 2, 8, 11, 3, 2, 17 };
            try
            {
                var sorter = bootstrapper.GetSorter();

                if (sorter == null)
                {
                    Console.WriteLine("{0} is null", nameof(sorter));
                    return;
                }

                var sortedNumbers = sorter.Sort(numbers, SortOrder.DESCENDING);

                if (sortedNumbers == null)
                {
                    Console.WriteLine("{0} are null", nameof(sortedNumbers));
                    return;
                }

                foreach (var number in sortedNumbers)
                    Console.WriteLine(number);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}

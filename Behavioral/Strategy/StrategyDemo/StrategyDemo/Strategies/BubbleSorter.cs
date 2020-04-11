using System.Collections.Generic;
using System.Linq;

namespace StrategyDemo.Strategies
{
    public class BubbleSorter : AbstractSorter
    {
        public override IEnumerable<int> Sort(IEnumerable<int> numbers, SortOrder order)
        {
            if (numbers == null || numbers.Count() < 2)
                return numbers;

            var result = numbers.ToArray();

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (IsWrongOrder(result[i], result[j], order))
                    {
                        var temp = result[j];
                        result[j] = result[i];
                        result[i] = temp;
                    }
                }
            }

            return result;
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace StrategyDemo.Strategies
{
    public class InsertionSorter : AbstractSorter
    {
        public override IEnumerable<int> Sort(IEnumerable<int> numbers, SortOrder order)
        {
            if (numbers == null || numbers.Count() < 2)
                return numbers;

            var inputs = numbers.ToArray();
            var result = new List<int>() { inputs[0] };

            for (int j = 1; j < inputs.Length; j++)
            {
                bool isInserted = false;

                for (int i = 0; i < result.Count; i++)
                {
                    if (IsWrongOrder(result[i], inputs[j], order))
                    {
                        result.Insert(i, inputs[j]);
                        isInserted = true;
                        break;
                    }
                }

                if (!isInserted)
                    result.Add(inputs[j]);
            }

            return result;
        }
    }
}

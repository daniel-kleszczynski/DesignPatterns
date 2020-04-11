using System.Collections.Generic;

namespace StrategyDemo.Strategies
{
    public abstract class AbstractSorter
    {
        public abstract IEnumerable<int> Sort(IEnumerable<int> numbers, SortOrder order);

        protected bool IsWrongOrder(int left, int right, SortOrder order)
        {
            if (order == SortOrder.ASCENDING)
                return right < left;

            return left < right;
        }
    }

    public enum SortOrder
    {
        ASCENDING,
        DESCENDING
    }
}

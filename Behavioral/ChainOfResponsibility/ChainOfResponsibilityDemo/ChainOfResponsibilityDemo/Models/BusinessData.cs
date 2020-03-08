namespace ChainOfResponsibilityDemo.Models
{
    public class BusinessData
    {
        public BusinessData(bool isA, bool isB, bool isC)
        {
            IsA = isA;
            IsB = isB;
            IsC = isC;
        }

        public bool IsA { get; }
        public bool IsB { get; }
        public bool IsC { get; }
    }
}

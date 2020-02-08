using ThirdPartyLibrary;

namespace AdapterDemo.Adapters
{
    public class WeightServiceAdapterObsolete : IWeightServiceAdapter
    {
        private WeightServiceObsolete service;

        public WeightServiceAdapterObsolete(WeightServiceObsolete service)
        {
            this.service = service;
        }

        public double GetWeight()
        {
            var ounces = service.GetWeightObsolete(WeightUnit.OUNCE);
            return ConvertOuncesToGrams(ounces);
        }

        private double ConvertOuncesToGrams(double ounces)
        {
            const double OUNCES_TO_GRAMS = 28.35;
            return ounces * OUNCES_TO_GRAMS;
        }
    }
}

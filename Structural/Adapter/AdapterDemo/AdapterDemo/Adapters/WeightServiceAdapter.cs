using ThirdPartyLibrary;

namespace AdapterDemo.Adapters
{
    public class WeightServiceAdapter : IWeightServiceAdapter
    {
        private WeightService service;

        public WeightServiceAdapter(WeightService service)
        {
            this.service = service;
        }

        public double GetWeight()
        {
            var pounds = service.GetWeightInPounds();
            return ConvertPoundsToGrams(pounds);
        }

        private double ConvertPoundsToGrams(double pounds)
        {
            const double POUNDS_TO_GRAMS = 453.59237;
            return pounds * POUNDS_TO_GRAMS;
        }
    }
}

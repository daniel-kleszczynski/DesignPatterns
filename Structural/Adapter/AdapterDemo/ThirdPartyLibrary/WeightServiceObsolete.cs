namespace ThirdPartyLibrary
{
    public class WeightServiceObsolete
    {
        public double GetWeightObsolete(WeightUnit weightUnit)
        {
            const double WEIGHT_IN_POUNDS = 11.11;
            const double WEIGHT_IN_OUNCES = 177.76;

            return weightUnit == WeightUnit.POUND ? WEIGHT_IN_POUNDS : WEIGHT_IN_OUNCES;
        }
    }
}

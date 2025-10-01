using BridgeProject;

namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Vehicle
    {
        public override double Price()
        {
            double basePrice = 240;
            //return HasBrobizz ? basePrice * 0.95 : basePrice;
            return HasBrobizz ? 228 : 230;

        }

        public override string VehicleType()
        {
            return "Storebæltsbil";
        }
    }
}



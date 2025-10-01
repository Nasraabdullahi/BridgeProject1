namespace BridgeProject
{
    public class MC : Vehicle
    {
        public override double Price()
        {
            double basePrice = 120;
            return HasBrobizz ? basePrice * 0.9 : basePrice;
        }

        public override string VehicleType() => "MC";
    }
}
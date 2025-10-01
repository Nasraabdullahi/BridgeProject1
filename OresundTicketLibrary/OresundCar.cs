using BridgeProject;

namespace OresundTicketLibrary
{
    public class OresundCar : Vehicle
    {
        public override double Price()
        {
            //return HasBrobizz ? 161 : 410;
            return HasBrobizz ? 178 : 460;

        }

        public override string VehicleType()
        {
            return "Øresundsbil";
        }
    }
}
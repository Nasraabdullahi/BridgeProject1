namespace BridgeProject
{
    
    //Arver fra den abstrakte klasse vehicle
    public class Car : Vehicle
    {
        public override double Price()
        {
            //grundprisen for car er 230 kroner
            double basePrice = 230;
            //hvis der er brobizz på, så er der 10% rabat
            return HasBrobizz ? basePrice * 0.9 : basePrice;
        }

        //implementerer den abstrakte metode Vehicletype, fra superklassen vechicle
        public override string VehicleType() => "Car";
    }
}
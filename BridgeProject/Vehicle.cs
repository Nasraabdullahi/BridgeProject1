namespace BridgeProject
{
    
    // vehicle er en abstrakt klasse, som vores andre klasser kan arve fra
    public abstract class Vehicle
    {
        private string _licensePlate = string.Empty;
        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                //sikrer at nummerpladen ikke overstiger 7 tegn, som er maximumet
                if (value.Length > 7)
                    throw new ArgumentException("License plate cannot exceed 7 characters");
                _licensePlate = value;
            }
        }

        public DateTime Date { get; set; }
        public bool HasBrobizz { get; set; }

        //abstrakt metode som skal implementeres af underklasserne
        public abstract double Price();
        
        //abstrakt metode som skal implementeres af underklasserne
        //retunere typen af køretøj
        public abstract string VehicleType();
    }
}


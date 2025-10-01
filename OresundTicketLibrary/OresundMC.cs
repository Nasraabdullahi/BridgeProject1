using BridgeProject;

namespace OresundTicketLibrary
{
    //klassen arver fra Mc og repræsentere en Mc der køre på øresundsbroen
    public class OresundMC : MC
    {
        //her overksrives pris metoden, for at der skal retuneres en fast pris afhængigt af brobizz
        //så hvis brobizz er korrekt skal der gives en rabat, ellers er det fuld pris
        public override double Price()
        {
            return HasBrobizz ? 92 : 235;
        }

        //her overskrives Vehicletypmetoden for at der skal retuneres en specifik type
        //der retuneres øresunds Mc, som er køretøjet
        public override string VehicleType() => "Oresund MC";
    }
}
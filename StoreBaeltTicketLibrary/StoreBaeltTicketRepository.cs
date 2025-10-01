using System.Collections.Generic;
using System.Linq;
using BridgeProject;

namespace StoreBaeltTicketLibrary
{
    //repository klasse til at håndtere billeter til storebæltsbroen
    public static class StoreBaeltTicketRepository
    {
        // Statisk liste som gemmer alle billetter
        private static readonly List<Vehicle> Tickets = new();

        // metode som er til at tilføje en billet til listen
        public static void AddTicket(Vehicle vehicle)
        {
            Tickets.Add(vehicle);
        }

        // metode som er til at hente alle de gemte billetter
        public static IEnumerable<Vehicle> GetAllTickets()
        {
            return Tickets;
        }

        // metode som er til for at hente billetter for et bestemt nummerplade
        //her retuneres der kun de billetter hvor nrpladen matcher inputet
        public static IEnumerable<Vehicle> GetTicketsByLicensePlate(string licensePlate)
        {
            return Tickets.Where(v => v.LicensePlate == licensePlate);
        }
    }
}
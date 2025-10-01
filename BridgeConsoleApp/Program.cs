
using OresundTicketLibrary;
using StoreBaeltTicketLibrary;

class Program
{
    static void Main()
    {
        // Storebælt test
        var car = new StoreBaeltCar { LicensePlate = "AB12345", HasBrobizz = true };
        StoreBaeltTicketRepository.AddTicket(car);

        Console.WriteLine("Alle Storebælts billetter:");
        foreach (var ticket in StoreBaeltTicketRepository.GetAllTickets())
        {
            Console.WriteLine($"{ticket.LicensePlate} - {ticket.VehicleType()} - {ticket.Price()} kr.");
        }

        // Øresund test
        var oresundCar = new OresundCar { LicensePlate = "XY99999", HasBrobizz = false };
        Console.WriteLine($"\nOresund billet: {oresundCar.LicensePlate} - {oresundCar.VehicleType()} - {oresundCar.Price()} kr.");
    }
}
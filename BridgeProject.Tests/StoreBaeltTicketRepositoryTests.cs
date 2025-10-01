using System.Linq;
using Xunit;
using StoreBaeltTicketLibrary;

namespace BridgeProject.Tests
{
    public class StoreBaeltTicketRepositoryTests
    {
        [Fact]
        //tester om at tilføjelsen af en billet vil øge antallet af gemte billetter
        public void AddTicket_ShouldIncreaseTicketCount()
        {
            var car = new StoreBaeltCar { LicensePlate = "AB12345", HasBrobizz = false };
        //en billet tilføjes til repository
            StoreBaeltTicketRepository.AddTicket(car);
       //Der bekræftes at den tilføjede billet findes i listen over alle billetter
            Assert.Contains(StoreBaeltTicketRepository.GetAllTickets(), t => t.LicensePlate == "AB12345");
        }

        [Fact]
        //tester om at søgning af nummerplade kun retunererer billetter med den specifikke nummerplade
        public void GetTicketsByLicensePlate_ShouldReturnOnlyMatchingTickets()
        {
            var car1 = new StoreBaeltCar { LicensePlate = "ZZ99999", HasBrobizz = false };
            var car2 = new StoreBaeltCar { LicensePlate = "YY88888", HasBrobizz = true };
       //her tilføjes der to forskellige billetter
            StoreBaeltTicketRepository.AddTicket(car1);
            StoreBaeltTicketRepository.AddTicket(car2);
       //her hentes billetter med nummerpladen...
            var result = StoreBaeltTicketRepository.GetTicketsByLicensePlate("ZZ99999");
       //her bekræftes der at kun en billet retuneres - den der har den korrekte nummerplade       
            Assert.Single(result); // Kun 1 billet
            Assert.Equal("ZZ99999", result.First().LicensePlate);
        }
    }
}
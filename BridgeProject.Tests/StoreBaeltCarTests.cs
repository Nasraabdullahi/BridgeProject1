using StoreBaeltTicketLibrary;
using StoreBaeltTicketLibrary;
using OresundTicketLibrary;


namespace BridgeProject.Tests
{
    public class StoreBaeltCarTests
    {
        [Fact]
        //her tester jeg om at prisen er 230 for en bil uden brobizz på en mandag
        public void Price_ShouldReturn230_OnWeekdayWithoutBrobizz()
        {
            var car = new StoreBaeltCar
            {
                Date = new DateTime(2024, 9, 30), // Mandag
                HasBrobizz = false// der ingen brobizz rabat
            };

            Assert.Equal(240, car.Price(), 1);// der forventes en fuld pris med tolorance på 1 kr
        }
    }
}



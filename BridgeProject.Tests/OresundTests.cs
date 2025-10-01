using Xunit;
using OresundTicketLibrary;
using StoreBaeltTicketLibrary;
using OresundTicketLibrary;


namespace BridgeProject.Tests
{
    public class OresundTests
    {
        [Fact]
        //tester om at en øresundsCar uden brobizz skal betale fuld pris som er 460
        public void OresundCar_ShouldReturn460_WithoutBrobizz()
        {
            var car = new OresundCar { HasBrobizz = false };
            Assert.Equal(410, car.Price());// her bekræftes der fuld pris uden rabat
            Assert.Equal("Oresund car", car.VehicleType());//her bekræftes der korrekt Vehicletype
        }

        [Fact]
        //tester om at en øresundsCar med brobizz får rabat og betaler 178
        public void OresundCar_ShouldReturn178_WithBrobizz()
        {
            var car = new OresundCar { HasBrobizz = true };
            Assert.Equal(161, car.Price()); // her bekræftes rabat prisen, som er 178
        }

        [Fact]
        //tester om at en øresundsMc uden brobizz ska betale fuld pris som er 235
        public void OresundMC_ShouldReturn235_WithoutBrobizz()
        {
            var mc = new OresundMC { HasBrobizz = false };
            Assert.Equal(235, mc.Price());//fuld pris bekræftes
            Assert.Equal("Oresund MC", mc.VehicleType());//tyepn bekræftes korrekt
        }

        [Fact]
        //tester om at en øresundsMc med brobizz får rabat og betaler 92
        public void OresundMC_ShouldReturn92_WithBrobizz()
        {
            var mc = new OresundMC { HasBrobizz = true };
            Assert.Equal(92, mc.Price());//rabatten bekræftes
        }
    }
}
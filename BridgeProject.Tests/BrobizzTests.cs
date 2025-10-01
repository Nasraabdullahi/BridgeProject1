namespace BridgeProject.Tests
{
    public class BrobizzTests
    {
        [Fact]
       // tester om at en bil med brobizz for 10% rabat
        public void Car_WithBrobizz_ShouldGive10PercentDiscount()
        {
            var car = new BridgeProject.Car { HasBrobizz = true };
            var price = car.Price();
            Assert.Equal(207, price, 1); // 1kr = tolerance 230 - 10% = 207 kr
        }

        [Fact]
        //tester om at en bil uden brobizz skal betale fuld pris som forventet
        public void Car_WithoutBrobizz_ShouldReturnFullPrice()
        {
            var car = new BridgeProject.Car { HasBrobizz = false };
            var price = car.Price();
            Assert.Equal(230, price, 1); // den fulde pris skal betales, som er 230 k
        }

        [Fact]
        //tester om at en Mc med brobizz får 10% rabat
        public void MC_WithBrobizz_ShouldGive10PercentDiscount()
        {
            var mc = new BridgeProject.MC { HasBrobizz = true };
            var price = mc.Price();
            Assert.Equal(108, price, 1); //1 kr = tolorance 120 -10% = 108
        }

        [Fact]
        // tester om at en Mc uden brobizz skal betale fuld pris
        public void MC_WithoutBrobizz_ShouldReturnFullPrice()
        {
            var mc = new BridgeProject.MC { HasBrobizz = false };
            var price = mc.Price();
            Assert.Equal(120, price, 1); //pris uden rabat - grundpris
        }
    }
}
namespace BridgeProject.Tests
{
    public class MCTests
    {
        [Fact]
        //tester om at prisen på en Mc uden brobizz er 120kr
        public void Price_ShouldReturn120()
        {
            var mc = new BridgeProject.MC();//instans oprettes
            var result = mc.Price();//prisen hentes
            Assert.Equal(120, result); //det bekræftes at prisen er korrekt:)
        }

        [Fact]
        //tester om at vehicletypemetoden rentunerer Mc
        public void VehicleType_ShouldReturnMC()
        {
            var mc = new BridgeProject.MC();//instans oprettes
            var result = mc.VehicleType(); //køretøjstypen hentes
            Assert.Equal("MC", result);//bekræfter typen er Mc
        }
    }
}
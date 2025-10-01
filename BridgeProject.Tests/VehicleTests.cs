namespace BridgeProject.Tests
{
    public class VehicleTests
    {
        [Fact]
        //tester om ay der kastes en ArgumentException hvis nummerpladen er længere end 7
        public void LicensePlate_ShouldThrowException_WhenLongerThan7Characters()
        {
            var car = new BridgeProject.Car();
            
            //exception kastes
            //nummerplade på 8tegn testes
            Assert.Throws<ArgumentException>(() => car.LicensePlate = "ABCDEFGH");
        }

        [Fact]
        //tester om at en nummerplade med 7 tegn virker uden fejl
        public void LicensePlate_ShouldAccept_When7CharactersOrLess()
        {
            var car = new BridgeProject.Car();
            //der tildeles en gyldig nrplade med 7
            car.LicensePlate = "ABC1234";
            //her bekræftes det at nrpladen er korrekt gemt
            Assert.Equal("ABC1234", car.LicensePlate);
        }
    }
}
namespace Pablo_Tests
{
    [TestClass]
    public class PabloEtterem
    {
        private PabloEtterem etterem;

        [TestInitialize]
        public void Setup()
        {
            etterem = new PabloEtterem();
        }
        [TestMethod]
        public void EtlapMegnyitasa_UjOldalMegjelenik()
        {
            var appMock = new Mock<PabloEtterem>();
            var app = appMock.Object;


            app.EtlapMegnyitasa();

            appMock.Verify(a => a.EtlapMegnyitasa(), Times.Once);
        }
        [TestMethod]
        public void BorlapMegnyitasa_UjOldalMegjelenik()
        {
            var appMock = new Mock<PabloEtterem>();
            var app = appMock.Object;

            app.BorlapMegnyitasa();

            appMock.Verify(a => a.BorlapMegnyitasa(), Times.Once);
        }
        [TestMethod]
        public void EtlapElonezetLatszik_IgazatAdVissza()
        {
            // Arrange
            var appMock = new Mock<PabloEtterem>();
            appMock.Setup(a => a.EtlapElonezetLatszik()).Returns(true);
            var app = appMock.Object;

            // Act
            var latszik = app.EtlapElonezetLatszik();

            // Assert
            Assert.IsTrue(latszik);
        }
        [TestMethod]
        public void AsztalfoglalasOldalLatszik_IgazatAdVissza()
        {
            // Arrange
            var appMock = new Mock<PabloEtterem>();
            appMock.Setup(a => a.AsztalfoglalasOldalLatszik()).Returns(true);
            var app = appMock.Object;

            // Act
            var latszik = app.AsztalfoglalasOldalLatszik();

            // Assert
            Assert.True(latszik);
        }
        [TestMethod]
        public void AsztaltFoglalas_FoglalasSikeres()
        {
            // Arrange
            var appMock = new Mock<PabloEtterem>();
            var app = appMock.Object;

            // Act
            app.AsztaltFoglalas();

            // Assert
            appMock.Verify(a => a.AsztaltFoglalas(), Times.Once);
            // Ellenõrizhetjük, hogy a foglalás sikeres volt-e
        }

    }
}
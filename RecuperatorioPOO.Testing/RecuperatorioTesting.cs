using RecuperatorioPOO.Entidades;

namespace RecuperatorioPOO.Testing
{
    [TestClass]
    public class RecuperatorioTesting
    {
        [TestMethod]
        public void AreaTesting()
        {
            double area = 550;
            var a =new PrismaRectangularRecto(10, 15, 5);
            Assert.AreEqual(area, a.Area());
        }
        public void VolumenTesting()
        {
            double volumen = 750;
            var a = new PrismaRectangularRecto(10, 15, 5);
            Assert.AreEqual(volumen, a.Volumen());
        }
        public void DiagonalTesting()
        {
            double diagonal = 15;
            var a = new PrismaRectangularRecto(10, 15, 5);
            Assert.AreNotEqual(diagonal, a.Diagonal());
        }
    }
}
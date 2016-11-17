using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio60_CL;

namespace UnitTestEjercicio60
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SinStockTest()
        {
            try
            {
                //Inicializo expendedora de gaseosa sin stock
                ExpendedoraGaseosa heladerita = new ExpendedoraGaseosa("marcaTest", new DateTime(2002, 08, 20), 0);

                //genero una transaccion sin stock
                heladerita.ImprimirTicket(10);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(ImpresionTicketException));
            }
        }

        [TestMethod]
        public void TransaccionDisminuyeStockEnUnoTest()
        {
            ExpendedoraGaseosa heladerita = new ExpendedoraGaseosa("marcaTest", new DateTime(2002, 08, 20), 2);

            heladerita.ImprimirTicket(10);

            Assert.AreEqual(1, heladerita._stock);
        }

        [TestMethod]
        public void TransaccionDisminuyePapelEnQuinceTest()
        {
            ExpendedoraBoletos maquinita = new ExpendedoraBoletos("marcaTest", new DateTime(2002, 08, 20), 20);

            maquinita.ImprimirTicket(10);

            Assert.AreEqual(5, maquinita._mmPapelDisponible);
        }
    }
}

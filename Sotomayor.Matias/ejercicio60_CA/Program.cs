using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicio60_CL;

namespace ejercicio60_CA
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpendedoraBoletos expBoletos = new ExpendedoraBoletos("LaMejor", new DateTime(2002, 11, 08), 60);
            ExpendedoraGaseosa expGaseosas = new ExpendedoraGaseosa("LaMasMejor", new DateTime(1999, 08, 12), 4);
            List<Expendedora> expendedoras = new List<Expendedora>();
            expendedoras.Add(expBoletos);
            expendedoras.Add(expGaseosas);

            Texto log = new Texto();
            Xml<List<Expendedora>> serializador = new Xml<List<Expendedora>>();

            try
            {
                expBoletos.ImprimirTicket(10);
            }
            catch (ImpresionTicketException e)
            {
                log.Guardar("log.txt", DateTime.Now.ToString() + " - " + e.Message);
            }

            try
            {
                expBoletos.ImprimirTicket(100);
            }
            catch (ImpresionTicketException e)
            {
                log.Guardar("log.txt", DateTime.Now.ToString() + " - " + e.Message);
            }

            try
            {
                expBoletos.ImprimirTicket(20);
            }
            catch (ImpresionTicketException e)
            {
                log.Guardar("log.txt", DateTime.Now.ToString() + " - " + e.Message);
            }

            try
            {
                expBoletos.ImprimirTicket(40);
            }
            catch (ImpresionTicketException e)
            {
                log.Guardar("log.txt", DateTime.Now.ToString() + " - " + e.Message);
            }

            try
            {
                expBoletos.ImprimirTicket(60);
            }
            catch (ImpresionTicketException e)
            {
                log.Guardar("log.txt", DateTime.Now.ToString() + " - " + e.Message);
            }

            Console.ReadKey();

            //****************************************************************************

            try
            {
                expGaseosas.ImprimirTicket(10);
            }
            catch (ImpresionTicketException e)
            {
                log.Guardar("log.txt", DateTime.Now.ToString() + " - " + e.Message);
            }

            try
            {
                expGaseosas.ImprimirTicket(15);
            }
            catch (ImpresionTicketException e)
            {
                log.Guardar("log.txt", DateTime.Now.ToString() + " - " + e.Message);
            }

            try
            {
                expGaseosas.ImprimirTicket(14);
            }
            catch (ImpresionTicketException e)
            {
                log.Guardar("log.txt", DateTime.Now.ToString() + " - " + e.Message);
            }

            try
            {
                expGaseosas.ImprimirTicket(17);
            }
            catch (ImpresionTicketException e)
            {
                log.Guardar("log.txt", DateTime.Now.ToString() + " - " + e.Message);
            }

            try
            {
                expGaseosas.ImprimirTicket(22);
            }
            catch (ImpresionTicketException e)
            {
                log.Guardar("log.txt", DateTime.Now.ToString() + " - " + e.Message);
            }

            Console.ReadKey();

            serializador.Guardar("Expendedoras.xml", expendedoras);
        }
    }
}

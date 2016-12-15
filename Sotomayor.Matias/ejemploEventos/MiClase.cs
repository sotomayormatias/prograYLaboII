using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ejemploEventos
{
    public class MiClase
    {
        public int tiempo;
        public delegate void MiDelegado(object mensaje);
        public event MiDelegado miEvento;

        public MiClase(int tiempo)
        { 
            this.tiempo = tiempo;
        }

        public void generadorDeEvento(object mensaje)
        {
            try 
	        {
                while (true)
                {
                    Thread.Sleep(this.tiempo);
                    miEvento(mensaje); 
                }
	        }
	        catch (Exception)
	        {
		
		        throw;
	        }
        }
    }
}

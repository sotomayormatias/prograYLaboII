using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio57_CL
{
    public interface ISerializable
    {
        string RutaDelArchivo
        {
            get;
            set;
        }

        bool DeSerializarse();
        bool Serializarse();
    }
}

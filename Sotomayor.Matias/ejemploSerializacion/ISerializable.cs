using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploSerializacion
{
    interface ISerializable<T>
    {
        bool leer(string ruta, out T dato);
        bool guardar(string ruta, T dato);
    }
}

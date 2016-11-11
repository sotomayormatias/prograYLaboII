using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface ISerializable<T>
    {
        bool guardar();
        bool modificar(int id);
        bool leer(int id);
        bool eliminar(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandezBarbero.Rodrigo.TP2_
{
    public interface Interface<T> where T : class
    {
        void Guardar(T dato);
        T Leer();


    }

}

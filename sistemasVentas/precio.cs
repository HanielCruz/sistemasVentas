using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemasVentas
{
     class precio : ticket
    {
        public override double Calcular()
        {
            
                return cantidadProducto * precioProducto;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ReconocimientoImagenes.clases
{
    public class abejaExploradora
    {
        abejaTrabajadora abejaOrigen;
        Point nueva_ubicacion;
        public abejaExploradora(abejaTrabajadora abeja)
        {
            abejaOrigen=abeja;
            nueva_ubicacion=abejaOrigen.GetAlimento().getUbicacion();
        }

        public abejaTrabajadora getAbejaOrigen()
        {
            return abejaOrigen;
        }
    }
}

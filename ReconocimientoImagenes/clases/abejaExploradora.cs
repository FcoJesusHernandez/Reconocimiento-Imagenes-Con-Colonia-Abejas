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

        public void explorar(int limite_superior_x, int limite_inferior_x, int limite_superior_y, int limite_inferior_y){
            // generar una nueva ubicacion
            while(nueva_ubicacion==abejaOrigen.GetAlimento().getUbicacion()){
                // randon para generar un nuevo alimento
            }
        }
    }
}

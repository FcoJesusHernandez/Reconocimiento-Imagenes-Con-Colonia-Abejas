using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ReconocimientoImagenes.clases
{
    public class alimento
    {
        Point ubicacion;
        double aptitud; // que tanto es diferente
        int contador;

        public alimento(int x, int y)
        {    
            ubicacion = new Point(x,y);
            contador = 0;
        }

        public void incrementarContador(){
            contador++;
        }

        public Point getUbicacion(){
            return ubicacion;
        } 
    }
}

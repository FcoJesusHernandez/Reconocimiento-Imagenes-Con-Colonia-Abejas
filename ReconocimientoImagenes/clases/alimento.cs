using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoImagenes.clases
{
    class alimento
    {
        Point ubicacion;
        int contador;

        public alimento(int x, int y)
        {    
            ubicacion = new Point(x,y);
            contador = 0;
        }

        private void incrementarContador(){
            contador++;
        }
    }
}

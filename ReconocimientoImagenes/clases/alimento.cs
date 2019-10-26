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
        Color color_alimento; // variable a verificar si es igual o no

        public alimento(int x, int y, Color color_)
        {    
            ubicacion = new Point(x,y);
            contador = 0;
            color_alimento = color_;
        }

        public void incrementarContador(){
            contador++;
        }

        public Point getUbicacion(){
            return ubicacion;
        } 

        public Color getColores(){
            return color_alimento;
        }

        public void setAptitud(Double aptitud){
            this.aptitud = aptitud;
        }
    }
}

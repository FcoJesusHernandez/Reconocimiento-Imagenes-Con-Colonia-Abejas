using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ReconocimientoImagenes.clases
{
    public class abejaTrabajadora
    {
        alimento fuente_alimento;
        int contador_sin_resultados;
        public abejaTrabajadora(alimento fuente_alimento)
        {
            this.fuente_alimento = fuente_alimento;
            contador_sin_resultados = 0;
        }

        public void incrementarContador(){
            contador_sin_resultados++;
        }

        public Point comunicarUbicacion(){
            return fuente_alimento.getUbicacion();
        }

        public int getContador(){
            return contador_sin_resultados;
        }

        public alimento GetAlimento(){
            return fuente_alimento;
        }

        public void serAlimento(alimento nuevo_alimento){
            fuente_alimento=nuevo_alimento;
        }
    }
}

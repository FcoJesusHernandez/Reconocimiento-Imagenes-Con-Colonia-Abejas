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
        abeja abejita;
        alimento fuente_alimento;
        int contador_sin_resultados; // iteraciones durante las cuales no se han obtenido resultados. 
        bool estoy_trabajando;
        int numero_maximo_intentos;

        public abejaTrabajadora(alimento fuente_alimento, abeja abeja, int intentos)
        {
            abejita = abeja;
            estoy_trabajando = false;
            this.fuente_alimento = fuente_alimento;
            contador_sin_resultados = 0;
            numero_maximo_intentos = intentos;
        }

        public void incrementarContador(){
            contador_sin_resultados++;
        }

        public int getNumeroMaximoIntentos()
        {
            return numero_maximo_intentos;
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

        public bool estoyTrabajando(){
            return estoy_trabajando;
        }

        public void hacerExploradora(){
            estoy_trabajando=false;
        }

        public void hacerTrabajadora(alimento nuevo_alimento){
            estoy_trabajando=true;
            fuente_alimento=nuevo_alimento;
            contador_sin_resultados = 0;
        }
    }
}

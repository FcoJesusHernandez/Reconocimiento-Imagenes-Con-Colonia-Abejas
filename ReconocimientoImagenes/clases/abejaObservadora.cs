using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocimientoImagenes.clases
{
    class abejaObservadora
    {
        abeja abejita;
        int alimentos_observados;

        public abejaObservadora(abeja abeja)
        {
            abejita = abeja;
            alimentos_observados = 0;
        }

        public double evaluar(alimento original, alimento para_verificar){  // retornara que tan apto es el alimento
            double porcentaje_igualdad = 100;
            if(original.getColores().R != para_verificar.getColores().R){
                // APLICAR REGLA DE TRES PARA SABER QUE TANTO ES DIFERENTE, 
                // EL 100 PORCIENTO CORRESPONDERAL 33.3% QUE LE CORRESPONDEN A ESTE COLOR (R).
                // LO QUE CORRESPONDA A ESE 33.3 % SERA RESTAR DE LA VARIBLE LO SOBRANTE
            }
            if(original.getColores().B != para_verificar.getColores().B){

            }
            if(original.getColores().G != para_verificar.getColores().G){

            }
            return porcentaje_igualdad;
        }

        public void incrementarAlimentosObservados(){
            alimentos_observados++;
        }
    }
}

using ReconocimientoImagenes.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ReconocimientoImagenes
{
    public class colonia
    {
        List<abeja> abejas;
        List<abejaExploradora> abejas_exploradoras;
        List<abejaTrabajadora> abejas_trabajadoras;
        List<abejaObservadora> abejas_observadoras;
        List<alimento> alimentos;

        Bitmap mundo_original;
        Bitmap mundo_comparacion;

        Bitmap bitmap_dibujable;

        Random rand = new Random();

        public colonia(int numero_abejas, float porcentaje_explotacion, float porcentaje_abejas_trabajadoras, Bitmap original, Bitmap comparar)
        {
            abejas = new List<abeja>();
            abejas_trabajadoras = new List<abejaTrabajadora>();
            abejas_observadoras = new List<abejaObservadora>();
            abejas_exploradoras = new List<abejaExploradora>();
            alimentos = new List<alimento>();

            int numero_intentos = (int)(10 * porcentaje_explotacion);
            int numero_abejas_trabajadoras = (int)(numero_abejas * porcentaje_abejas_trabajadoras);
            iniciarMundo(original,comparar);
            iniciarMundo(original,comparar);
            inicilizacionColonia(numero_abejas, numero_intentos, numero_abejas_trabajadoras);
        }

        private void inicilizacionColonia(int poblacion, int numero_intentos, int numero_abejas_trabajadoras)
        {
            for (int i = 0; i < poblacion; i++)
            {
                abeja nueva_abeja = new abeja(i);
                abejas.Add(nueva_abeja);
                if (abejas_trabajadoras.Count != numero_abejas_trabajadoras)
                {
                    alimento alimento_origen = obtenerAlimento();
                    alimentos.Add(alimento_origen);
                    evaluar(alimento_origen);
                    abejas_trabajadoras.Add(new abejaTrabajadora(alimento_origen, nueva_abeja, numero_intentos));
                }
                else
                {
                    abejas_observadoras.Add(new abejaObservadora(nueva_abeja));
                }
            }
        }

        private alimento obtenerAlimento()
        {
            alimento nuevo_alimento;
            
            do
            {
                int x = rand.Next(0, mundo_comparacion.Width);
                int y = rand.Next(0, mundo_comparacion.Height);
                nuevo_alimento = new alimento(x, y, mundo_comparacion.GetPixel(x,y));
            } while (alimentos.Contains(nuevo_alimento));

            return nuevo_alimento;
        }

        private alimento obtenerAlimento(alimento alimento_base)
        {
            alimento nuevo_alimento;

            do
            {
                int x = rand.Next(0, 10);
                int y = rand.Next(0, 10);

                int condicion_comunicacion_x = rand.Next(0, 10);
                int condicion_comunicacion_y = rand.Next(0, 10);

                if (esPrimo(condicion_comunicacion_x))
                {
                    x = alimento_base.getUbicacion().X + x;
                    if (x >= mundo_original.Width)
                    {
                        x = alimento_base.getUbicacion().X;
                    }
                }
                else
                {
                    x = alimento_base.getUbicacion().X - x;
                    if (x <= 0)
                    {
                        x = alimento_base.getUbicacion().X;
                    }
                }

                if (esPrimo(condicion_comunicacion_y))
                {
                    y = alimento_base.getUbicacion().Y + y;
                    if (y >= mundo_original.Height)
                    {
                        y = alimento_base.getUbicacion().Y;
                    }
                }
                else
                {
                    y = alimento_base.getUbicacion().Y - y;
                    if (y <= 0)
                    {
                        y = alimento_base.getUbicacion().Y;
                    }
                }
                nuevo_alimento = new alimento(x, y, mundo_comparacion.GetPixel(x, y));
            } while (alimentos.Contains(nuevo_alimento));

            return nuevo_alimento;
        }

        public double getEstadistica()
        {
            double porcentaje_abejas_trabajando = 0;
            
            double abejas_con_resultados_buenos = 0;

            foreach (abejaTrabajadora abeja_t in abejas_trabajadoras)
            {
                if (abeja_t.estoyTrabajando())
                {
                    if (abeja_t.GetAlimento().getAptitud() < 70 && abeja_t.GetAlimento().getAptitud()!=-1)
                    {
                        abejas_con_resultados_buenos++;
                    }
                }
            }

            porcentaje_abejas_trabajando = (double)( 100.0 / abejas_trabajadoras.Count ) * abejas_con_resultados_buenos;
            return porcentaje_abejas_trabajando;
        }

        private bool esPrimo(int numero)
        {
            int divisor = 2;
            int resto = 0;
            while (divisor < numero)
            {
                resto = numero % divisor;
                if (resto == 0)
                {
                    return false;
                }
                divisor = divisor + 1;
            }
            return true;
        }

        private alimento obtenerAlimentoTrabajador(alimento alimento_base)
        {
            alimento nuevo_alimento = alimento_base; 
            int y = alimento_base.getUbicacion().Y;
            int x = alimento_base.getUbicacion().X;

            int random1 = rand.Next(1, 5);
            switch (random1)
            {
                case 1:  // norte
                    if (alimento_base.getUbicacion().X >= 1)
                    {
                        do
                        {
                            x--;
                            if (x <= 0)
                            {
                                x++;
                            }
                            nuevo_alimento = new alimento(x, y, mundo_comparacion.GetPixel(x, y));
                        } while (alimentos.Contains(nuevo_alimento));
                    }
                    else
                    {
                        do
                        {
                            x++;
                            if (x >= mundo_comparacion.Width)
                            {
                                x--;
                            }
                            nuevo_alimento = new alimento(x, y, mundo_comparacion.GetPixel(x, y));
                        } while (alimentos.Contains(nuevo_alimento));
                    }
                    break;
                case 2:  // sur
                    if (alimento_base.getUbicacion().X == mundo_comparacion.Width)
                    {
                        do
                        {
                            x--;
                            if (x <= 0)
                            {
                                x++;
                            }
                            nuevo_alimento = new alimento(x, y, mundo_comparacion.GetPixel(x, y));
                        } while (alimentos.Contains(nuevo_alimento));
                    }
                    else
                    {
                        do
                        {
                            x++;
                            if (x >= mundo_comparacion.Width)
                            {
                                x--;
                            }
                            nuevo_alimento = new alimento(x, y, mundo_comparacion.GetPixel(x, y));
                        } while (alimentos.Contains(nuevo_alimento));
                    }
                    break;
                case 3:  // este
                    if (alimento_base.getUbicacion().Y == mundo_original.Height)
                    {
                        do
                        {
                            y--;
                            if (y <= 0)
                            {
                                y++;
                            }
                            nuevo_alimento = new alimento(x, y, mundo_comparacion.GetPixel(x, y));
                        } while (alimentos.Contains(nuevo_alimento));
                    }
                    else
                    {
                        do
                        {
                            y++;
                            if (y >= mundo_comparacion.Height)
                            {
                                y--;
                            }
                            nuevo_alimento = new alimento(x, y, mundo_comparacion.GetPixel(x, y));
                        } while (alimentos.Contains(nuevo_alimento));
                    }
                    break;
                case 4:  // oeste
                    if (alimento_base.getUbicacion().Y != 1)
                    {
                        do
                        {
                            y--;
                            if (y <= 0)
                            {
                                y++;
                            }
                            nuevo_alimento = new alimento(x, y, mundo_comparacion.GetPixel(x, y));
                        } while (alimentos.Contains(nuevo_alimento));
                    }
                    else
                    {
                        do
                        {
                            y++;
                            if (y >= mundo_comparacion.Height)
                            {
                                y--;
                            }
                            nuevo_alimento = new alimento(x, y, mundo_comparacion.GetPixel(x, y));
                        } while (alimentos.Contains(nuevo_alimento));
                    }
                    break;
            }
            return nuevo_alimento;
        }

        public void iniciarMundo(Bitmap original, Bitmap comparar)
        {
            mundo_original = original;
            mundo_comparacion = comparar;
            bitmap_dibujable = new Bitmap(mundo_comparacion.Width, mundo_comparacion.Height);
        }

        public Bitmap getBitmap()
        {
            foreach(alimento alimento_actual in alimentos)
            {
                if (alimento_actual.getAptitud() < 80)
                {

                }
                bitmap_dibujable.SetPixel(alimento_actual.getUbicacion().X,alimento_actual.getUbicacion().Y, dameColorBitmap(alimento_actual.getAptitud()));
            }
            return bitmap_dibujable;
        }

        private Color dameColorBitmap(double aptitud)
        {
            Color color_bitmap = new Color();
            if (aptitud >= 95)
            {
                color_bitmap = ColorTranslator.FromHtml("#3e8c0d");
            }
            else if (aptitud >= 90)
            {
                color_bitmap = ColorTranslator.FromHtml("#bcf57e");
            }
            else if (aptitud >= 80)
            {
                color_bitmap = ColorTranslator.FromHtml("#f2fb6f");
            }
            else if (aptitud >= 70)
            {
                color_bitmap = ColorTranslator.FromHtml("#fbd06f");
            }
            else if (aptitud >= 60)
            {
                color_bitmap = ColorTranslator.FromHtml("#fb966f");
            }
            else
            {
                color_bitmap = ColorTranslator.FromHtml("#fb6f6f");
            }
            return color_bitmap;
        }

        public void etapaAbejasTrabajadoras()
        {
            foreach (abejaTrabajadora abeja in abejas_trabajadoras)
            {
                abeja.estoyTrabajando();
                if (abeja.getContador() != abeja.getNumeroMaximoIntentos())
                {
                    trabajar(abeja);
                }
            }
        }

        private void trabajar(abejaTrabajadora abeja)
        {
            alimento nuevo_alimento_busqueda = obtenerAlimentoTrabajador(abeja.GetAlimento());
            alimentos.Add(nuevo_alimento_busqueda);
            if (evaluar(nuevo_alimento_busqueda) < 90)
            {
                abeja.hacerTrabajadora(nuevo_alimento_busqueda);
            }
            else
            {
                abeja.incrementarContador();
            }
        }

        private double evaluar(alimento aliemnto)
        {
            double porcentaje_final;

            double porcentaje_r = 33.4;
            double porcentaje_b = 33.2;
            double porcentaje_g = 33.4;

            Color dato_original = mundo_original.GetPixel(aliemnto.getUbicacion().X, aliemnto.getUbicacion().Y);

            if (dato_original.R != aliemnto.getColores().R)
            {
                int porcentaje;
                if (dato_original.R > aliemnto.getColores().R)
                {
                    if (dato_original.R != 0)
                    {
                        porcentaje = (aliemnto.getColores().R * 100) / dato_original.R;
                    }
                    else
                    {
                        porcentaje = (aliemnto.getColores().R * 100) / 1;
                    }
                }
                else
                {
                    if (dato_original.R != 0)
                    {
                        porcentaje = ((dato_original.R - (aliemnto.getColores().R - dato_original.R)) * 100) / dato_original.R;
                    }
                    else
                    {
                        porcentaje = ((dato_original.R - (aliemnto.getColores().R - dato_original.R)) * 100) / 1;
                    }
                }
                porcentaje_r = (porcentaje * porcentaje_r) / 100;
            }
            if (dato_original.B != aliemnto.getColores().B)
            {
                int porcentaje;
                if (dato_original.B > aliemnto.getColores().B)
                {
                    if (dato_original.B != 0)
                    {
                        porcentaje = (aliemnto.getColores().B * 100) / dato_original.B;
                    }
                    else
                    {
                        porcentaje = (aliemnto.getColores().B * 100) / 1;
                    }
                }
                else
                {
                    if (dato_original.B != 0)
                    {
                        porcentaje = ((dato_original.B - (aliemnto.getColores().B - dato_original.B)) * 100) / dato_original.B;
                    }
                    else
                    {
                        porcentaje = ((dato_original.B - (aliemnto.getColores().B - dato_original.B)) * 100) / 1;
                    }
                }
                porcentaje_b = (porcentaje * porcentaje_b) / 100;
            }
            if (dato_original.G != aliemnto.getColores().G)
            {
                int porcentaje;
                if (dato_original.G > aliemnto.getColores().G)
                {
                    if (dato_original.G != 0)
                    {
                        porcentaje = (aliemnto.getColores().G * 100) / dato_original.G;
                    }
                    else
                    {
                        porcentaje = (aliemnto.getColores().G * 100) / 1;
                    }
                }
                else
                {
                    if (dato_original.G != 0)
                    {
                        porcentaje = ((dato_original.G - (aliemnto.getColores().G - dato_original.G)) * 100) / dato_original.G;
                    }
                    else
                    {
                        porcentaje = ((dato_original.G - (aliemnto.getColores().G - dato_original.G)) * 100) / 1;
                    }
                }
                porcentaje_g = (porcentaje * porcentaje_g) / 100;
            }

            porcentaje_final = (porcentaje_r + porcentaje_g + porcentaje_b);
            if (porcentaje_final < 0)
            {
                porcentaje_final = 0;
            }

            aliemnto.setAptitud(porcentaje_final);
            
            return porcentaje_final;
        }

        public void etapaAbejaExploradora()
        {
            foreach (abejaExploradora abeja in abejas_exploradoras)
            {
                if (esPrimo(rand.Next(2, 6)))
                {
                    abeja.getAbejaOrigen().hacerTrabajadora(obtenerAlimento());
                }
                else
                {
                    abeja.getAbejaOrigen().hacerTrabajadora(obtenerAlimento(ruleta()));
                }
            }
            abejas_exploradoras.Clear();
        }

        private alimento ruleta()
        {
            double aptitud = 0;

            List<double> probabilidad = new List<double>();
            for (int i = 0; i < abejas_trabajadoras.Count; i++)
            {
                probabilidad.Add(0);
            }

            foreach (abejaTrabajadora abeja_t in abejas_trabajadoras)
            {
                aptitud = aptitud + abeja_t.GetAlimento().getAptitud();
            }

            for (int i = 0; i < abejas_trabajadoras.Count; i++)
            {
                abejaTrabajadora abeja_t = abejas_trabajadoras[i];
                probabilidad[i] = abeja_t.GetAlimento().getAptitud() / aptitud;
            }

            double r = rand.Next(0, 1);

            double psum = 0;
            for (int i = 0; i < abejas_trabajadoras.Count; i++)
            {
                abejaTrabajadora abeja_t = abejas_trabajadoras[i];
                psum = psum + probabilidad[i];
                if (psum < r)
                {
                    return abeja_t.GetAlimento();
                }
            }

            return abejas_trabajadoras[rand.Next(0, abejas_trabajadoras.Count)].GetAlimento();
        }

        public void etapaAbejaObservadora()
        {
            foreach (abejaObservadora abeja in abejas_observadoras)
            {
                foreach(abejaTrabajadora abeja_t in abejas_trabajadoras)
                {
                    if (abeja_t.getContador()>=abeja_t.getNumeroMaximoIntentos())
                    {
                        abeja_t.hacerExploradora();
                        abejas_exploradoras.Add(new abejaExploradora(abeja_t));
                    }
                }
            }
        }
    }
}

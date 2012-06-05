using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ProyectoFinal
{
    public static class Funciones
    {

        //función para validar email
        public static bool ValidarEmail(string email)
        {
            if (!Regex.Match(email, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*").Success)
            {
                //Email incorrecto
                return false;
            }
            else
            {
                return true;
            }
        }


        //función para calcular la fecha exacta de vencimiento de presentar la demanda o documendo 
        //correspondiente a cada etapa procesal, por ejemplo en la segunda etapa se tienen 45 dias hábiles
        //para responder de que se inició, no se deben incluír los dias inhabiles del año ni fines de semana

        public static DateTime fechaLimite(DateTime fechaInicioEtapa, double diasVencimiento)
        {
            DateTime fechaLimite = fechaInicioEtapa;

            //Llamo a los dias inhabiles
            sistema.DiaNoHabil[] diasInhabiles = Program.frmPrincipal.servicioWeb.getDiaNoHabil("", "");
            //contador para ir incrementando los dias hasta que se cumplan los 45 dias habiles
            double siguiente = 0;
            //contador que incrementa el numero de dias que se le tendrán que sumar al final
            double extras = 0;
            double count = 0;
            DateTime fechaTemporal;

            while (count - extras <= diasVencimiento || diasVencimiento == 0) 
            {
                siguiente++;

                fechaTemporal = fechaLimite.AddDays(siguiente);
                //verifica si es sabado o domingo
                if (fechaTemporal.DayOfWeek == DayOfWeek.Saturday || fechaTemporal.DayOfWeek == DayOfWeek.Sunday)
                {
                    extras++;
                    count++;
                }
                else
                {
                    //si no es, verifica si es un dia inhabil
                    foreach (sistema.DiaNoHabil dia in diasInhabiles)
                    {
                        //compara la fecha temporal con el dia inhabil
                        if (DateTime.Compare(fechaTemporal.Date, dia.Dia.Date) == 0) //son iguales
                        {
                            extras++;
                            count++;
                        }
                    }
                    count++;
                }
            }
            return fechaInicioEtapa.AddDays(diasVencimiento + extras);

        }
    }
}

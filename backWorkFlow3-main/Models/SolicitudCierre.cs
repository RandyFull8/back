using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class solicitudCierre
    {

        //solicitud
        public int idSolicitud { get; set; }
        

        //cierreSolicitud

        public string fechaFinal { get; set; }

        public string horaFinal { get; set; }

        public string trabajoSanitizado { get; set; }

        public string estatusActividad { get; set; }

        public string firmaSolicitante { get; set; }

        public string emailSent2 { get; set; }


        public solicitudCierre() { }



        public solicitudCierre(

int IdSolicitud, 

//cierreSolicitud
string FechaFinal, string HoraFinal, string TrabajoSanitizado, string EstatusActividad,
string FirmaSolicitante, string EmailSent2
            )
        {
            idSolicitud = IdSolicitud;
           

            //cierreSolicitud
            fechaFinal = FechaFinal;
            horaFinal = HoraFinal;
            trabajoSanitizado = TrabajoSanitizado;
            estatusActividad = EstatusActividad;
            firmaSolicitante = FirmaSolicitante;
            emailSent2 = EmailSent2;
        }



        public solicitudCierre(

//cierreSolicitud
string FechaFinal, string HoraFinal, string TrabajoSanitizado, string EstatusActividad,
string FirmaSolicitante, string EmailSent2
            )
        {

            //cierreSolicitud
            fechaFinal = FechaFinal;
            horaFinal = HoraFinal;
            trabajoSanitizado = TrabajoSanitizado;
            estatusActividad = EstatusActividad;
            firmaSolicitante = FirmaSolicitante;
            emailSent2 = EmailSent2;

        }




    }
}




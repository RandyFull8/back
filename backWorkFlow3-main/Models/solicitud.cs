using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class solicitud
    {

        //solicitud
        public int idSolicitud { get; set; }
        public string nombreSolicitante { get; set; }

        public string correo { get; set; }

        public string fechaSolicitud { get; set; }

        public string horaSolicitud { get; set; }

        public string area { get; set; }

        public string maquina { get; set; }

        public string dispositivo { get; set; }

        public string descripcionProblema { get; set; }

        //diagnostico


        public int nomina { get; set; }
        public string nombre { get; set; }

        public string fechaInicio { get; set; }

        public string horaInicio { get; set; }

        public string diagnostico { get; set; }

        public string tipoFalla { get; set; }

        public string emailSent { get; set; }

        //reparacion

        public string generoParo { get; set; }

        public int paroCorrectivo { get; set; }

        public int paroOperativo { get; set; }

        public int paroRefaccion { get; set; }

        public int tiempoTotal { get; set; }

        public string grasaUtilizada { get; set; }

        public string refaMateHerra { get; set; }

        //cierreSolicitud

        public string fechaFinal { get; set; }

        public string horaFinal { get; set; }

        public string trabajoSanitizado { get; set; }

        public string estatusActividad { get; set; }

        public string firmaSolicitante { get; set; }

        public string emailSent2 { get; set; }


        public solicitud() { }



        public solicitud(
//solicitud
int IdSolicitud, string NombreSolicitante, string Correo, string FechaSolicitud,
string HoraSolicitud, string Area, string Maquina, string Dispositivo, string DescripcionProblema,
        //diagnostico
int Nomina, string Nombre, string FechaInicio, string HoraInicio,
string Diagnostico, string TipoFalla, string EmailSent,

        //reparacion
string GeneroParo, int ParoCorrectivo, int ParoOperativo, int ParoRefaccion,
int TiempoTotal, string GrasaUtilizada, string RefaMateHerra,

//cierreSolicitud
string FechaFinal, string HoraFinal, string TrabajoSanitizado, string EstatusActividad,
string FirmaSolicitante, string EmailSent2
            )
        {
            idSolicitud = IdSolicitud;
            nombreSolicitante = NombreSolicitante;
            correo = Correo;
            fechaSolicitud = FechaSolicitud;
            horaSolicitud = HoraSolicitud;
            area = Area;
            maquina = Maquina;
            dispositivo = Dispositivo;
            descripcionProblema = DescripcionProblema;
            //diagnostico
            nomina = Nomina;
            nombre = Nombre;
            fechaInicio = FechaInicio;
            horaInicio = HoraInicio;
            diagnostico = Diagnostico;
            tipoFalla = TipoFalla;
            emailSent = EmailSent;

            //reparacion
            generoParo = GeneroParo;
            paroCorrectivo = ParoCorrectivo;
            paroOperativo = ParoOperativo;
            paroRefaccion = ParoRefaccion;
            tiempoTotal = TiempoTotal;
            grasaUtilizada = GrasaUtilizada;
            refaMateHerra = RefaMateHerra;

            //cierreSolicitud
            fechaFinal = FechaFinal;
            horaFinal = HoraFinal;
            trabajoSanitizado = TrabajoSanitizado;
            estatusActividad = EstatusActividad;
            firmaSolicitante = FirmaSolicitante;
            emailSent2 = EmailSent2;
        }



        public solicitud(
string NombreSolicitante, string Correo, string FechaSolicitud,
string HoraSolicitud, string Area, string Maquina, string Dispositivo, string DescripcionProblema,
        //diagnostico
int Nomina, string Nombre, string FechaInicio, string HoraInicio,
string Diagnostico, string TipoFalla, string EmailSent,

        //reparacion
string GeneroParo, int ParoCorrectivo, int ParoOperativo, int ParoRefaccion,
int TiempoTotal, string GrasaUtilizada, string RefaMateHerra,

//cierreSolicitud
string FechaFinal, string HoraFinal, string TrabajoSanitizado, string EstatusActividad,
string FirmaSolicitante, string EmailSent2
            )
        {
            nombreSolicitante = NombreSolicitante;
            correo = Correo;
            fechaSolicitud = FechaSolicitud;
            horaSolicitud = HoraSolicitud;
            area = Area;
            maquina = Maquina;
            dispositivo = Dispositivo;
            descripcionProblema = DescripcionProblema;
            //diagnostico
            nomina = Nomina;
            nombre = Nombre;
            fechaInicio = FechaInicio;
            horaInicio = HoraInicio;
            diagnostico = Diagnostico;
            tipoFalla = TipoFalla;
            emailSent = EmailSent;

            //reparacion
            generoParo = GeneroParo;
            paroCorrectivo = ParoCorrectivo;
            paroOperativo = ParoOperativo;
            paroRefaccion = ParoRefaccion;
            tiempoTotal = TiempoTotal;
            grasaUtilizada = GrasaUtilizada;
            refaMateHerra = RefaMateHerra;

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




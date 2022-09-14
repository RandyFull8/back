using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EASendMail;


namespace back_salidaActivos.Models
{
    public class GestorSolicitud
    {
        public List<solicitud> GetSolicituds()
        {
            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "solicitudMantenimiento_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idSolicitud = dr.GetInt32(0);
                    string nombreSolicitante = dr.GetString(1).Trim();
                    string correo = dr.GetString(2).Trim();
                    string fechaSolicitud = dr.GetString(3).Trim();
                    string horaSolicitud = dr.GetString(4).Trim();
                    string area = dr.GetString(5).Trim();
                    string maquina = dr.GetString(6).Trim();
                    string dispositivo = dr.GetString(7).Trim();
                    string descripcionProblema = dr.GetString(8).Trim();


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();

                    //reparacion
                    string generoParo = dr.GetString(16).Trim();
                    int paroCorrectivo = dr.GetInt32(17);
                    int paroOperativo = dr.GetInt32(18);
                    int paroRefaccion = dr.GetInt32(19);
                    int tiempoTotal= dr.GetInt32(20);
                    string grasaUtilizada = dr.GetString(21).Trim();
                    string refaMateHerra = dr.GetString(22).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(23).Trim();
                    string horaFinal = dr.GetString(24).Trim();         
                    string trabajoSanitizado = dr.GetString(25).Trim();
                    string estatusActividad = dr.GetString(26).Trim();
                    string firmaSolicitante= dr.GetString(27).Trim();
                    string emailSent2 = dr.GetString(28).Trim();

                    solicitud Solicitud = new solicitud(
                    idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,

                    //reparacion
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    emailSent2
                        
                        );

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }
      
        public List<solicitud> GetSolicitudsById(int id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("select\r\n--solicitud\r\ns.idSolicitud,\r\n s.nombreSolicitante,\r\n s.correo,\r\n s.fechaSolicitud,\r\n s.horaSolicitud,\r\ns.area,\r\n s.maquina,\r\n s.dispositivo,\r\n s.descripcionProblema,\r\n--diagnostico\r\nd.nomina,\r\nm.nombre,\r\nd.fechaInicio,\r\nd.horaInicio,\r\nd.diagnostico,\r\nd.tipoFalla,\r\nd.emailSent,\r\n--reparacion\r\nr.generoParo,\r\nr.paroCorrectivo,\r\nr.paroOperativo,\r\nr.paroRefacccion,\r\nr.tiempoTotal,\r\nr.grasaUtilizada,\r\nr.refaMateHerra,\r\n--cierre\r\nc.fechaFinal,\r\nc.horaFinal,\r\nc.trabajoSanitizado,\r\nc.estatusActividad,\r\nc.firmaSolicitante,\r\nc.emailSent2\r\n\r\nfrom SolicitudPreventiva as S \r\ninner join Diagnostico as D \r\non S.idSolicitud=D.idSolicitud \r\ninner join Reparacion as R \r\non D.idSolicitud= R.idSolicitud \r\ninner join CierreSolicitud as C \r\non R.idSolicitud= C.idSolicitud\r\ninner join Mecanicos M\r\non D.nomina=M.nomina\r\nwhere s.idSolicitud=" + id2, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idSolicitud = dr.GetInt32(0);
                    string nombreSolicitante = dr.GetString(1).Trim();
                    string correo = dr.GetString(2).Trim();
                    string fechaSolicitud = dr.GetString(3).Trim();
                    string horaSolicitud = dr.GetString(4).Trim();
                    string area = dr.GetString(5).Trim();
                    string maquina = dr.GetString(6).Trim();
                    string dispositivo = dr.GetString(7).Trim();
                    string descripcionProblema = dr.GetString(8).Trim();


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();

                    //reparacion
                    string generoParo = dr.GetString(16).Trim();
                    int paroCorrectivo = dr.GetInt32(17);
                    int paroOperativo = dr.GetInt32(18);
                    int paroRefaccion = dr.GetInt32(19);
                    int tiempoTotal = dr.GetInt32(20);
                    string grasaUtilizada = dr.GetString(21).Trim();
                    string refaMateHerra = dr.GetString(22).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(23).Trim();
                    string horaFinal = dr.GetString(24).Trim();
                    string trabajoSanitizado = dr.GetString(25).Trim();
                    string estatusActividad = dr.GetString(26).Trim();
                    string firmaSolicitante = dr.GetString(27).Trim();
                    string emailSent2 = dr.GetString(28).Trim();

                    solicitud Solicitud = new solicitud( idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,

                    //reparacion
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    emailSent2);

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }




        public List<solicitud> GetSolicitudsById2(int id2)
        {

            List<solicitud> lista = new List<solicitud>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                String temp = id2 + "";

                SqlCommand cmd = new SqlCommand("select\r\n--solicitud\r\ns.idSolicitud,\r\n s.nombreSolicitante,\r\n s.correo,\r\n s.fechaSolicitud,\r\n s.horaSolicitud,\r\ns.area,\r\n s.maquina,\r\n s.dispositivo,\r\n s.descripcionProblema,\r\n--diagnostico\r\nd.nomina,\r\nm.nombre,\r\nd.fechaInicio,\r\nd.horaInicio,\r\nd.diagnostico,\r\nd.tipoFalla,\r\nd.emailSent,\r\n--reparacion\r\nr.generoParo,\r\nr.paroCorrectivo,\r\nr.paroOperativo,\r\nr.paroRefacccion,\r\nr.tiempoTotal,\r\nr.grasaUtilizada,\r\nr.refaMateHerra,\r\n--cierre\r\nc.fechaFinal,\r\nc.horaFinal,\r\nc.trabajoSanitizado,\r\nc.estatusActividad,\r\nc.firmaSolicitante,\r\nc.emailSent2\r\n\r\nfrom SolicitudPreventiva as S \r\ninner join Diagnostico as D \r\non S.idSolicitud=D.idSolicitud \r\ninner join Reparacion as R \r\non D.idSolicitud= R.idSolicitud \r\ninner join CierreSolicitud as C \r\non R.idSolicitud= C.idSolicitud\r\ninner join Mecanicos M\r\non D.nomina=M.nomina\r\n where d.nomina=" + temp, conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idSolicitud = dr.GetInt32(0);
                    string nombreSolicitante = dr.GetString(1).Trim();
                    string correo = dr.GetString(2).Trim();
                    string fechaSolicitud = dr.GetString(3).Trim();
                    string horaSolicitud = dr.GetString(4).Trim();
                    string area = dr.GetString(5).Trim();
                    string maquina = dr.GetString(6).Trim();
                    string dispositivo = dr.GetString(7).Trim();
                    string descripcionProblema = dr.GetString(8).Trim();


                    //diagnostico
                    int nomina = dr.GetInt32(9);
                    string nombre = dr.GetString(10).Trim();
                    string fechaInicio = dr.GetString(11).Trim();
                    string horaInicio = dr.GetString(12).Trim();
                    string diagnostico = dr.GetString(13).Trim();
                    string tipoFalla = dr.GetString(14).Trim();
                    string emailSent = dr.GetString(15).Trim();

                    //reparacion
                    string generoParo = dr.GetString(16).Trim();
                    int paroCorrectivo = dr.GetInt32(17);
                    int paroOperativo = dr.GetInt32(18);
                    int paroRefaccion = dr.GetInt32(19);
                    int tiempoTotal = dr.GetInt32(20);
                    string grasaUtilizada = dr.GetString(21).Trim();
                    string refaMateHerra = dr.GetString(22).Trim();

                    //cierre solicitud
                    string fechaFinal = dr.GetString(23).Trim();
                    string horaFinal = dr.GetString(24).Trim();
                    string trabajoSanitizado = dr.GetString(25).Trim();
                    string estatusActividad = dr.GetString(26).Trim();
                    string firmaSolicitante = dr.GetString(27).Trim();
                    string emailSent2 = dr.GetString(28).Trim();

                    solicitud Solicitud = new solicitud(idSolicitud,
                    nombreSolicitante,
                    correo,
                    fechaSolicitud,
                    horaSolicitud,
                    area,
                    maquina,
                    dispositivo,
                    descripcionProblema,
                    //diagnostico
                    nomina,
                    nombre,
                    fechaInicio,
                    horaInicio,
                    diagnostico,
                    tipoFalla,
                    emailSent,

                    //reparacion
                    generoParo,
                    paroCorrectivo,
                    paroOperativo,
                    paroRefaccion,
                    tiempoTotal,
                    grasaUtilizada,
                    refaMateHerra,

                    //cierreSolicitud
                    fechaFinal,
                    horaFinal,
                    trabajoSanitizado,
                    estatusActividad,
                    firmaSolicitante,
                    emailSent2);

                    lista.Add(Solicitud);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }







        public bool addSolicitud(solicitud Solicitud)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "solicitud_Add";
                cmd.CommandType = CommandType.StoredProcedure;
                
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
            
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }
                return res;
            }


        }


        public bool updateSolicitud(int id, solicitud Solicitud)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
               
                //

                //
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }
                return res;
            }


        }

        public bool deleteSolicitud(int id)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "solicitudMantenimientoDelete";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_solicitud", id);

                //

                //
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    res = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    res = false;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }
                return res;
            }


        }

    }
}
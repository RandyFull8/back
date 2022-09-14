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
    public class GestorMaquinas
    {
        public List<maquinas> GetMaquinas()
        {
            List<maquinas> lista = new List<maquinas>();
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "MaquinasMantenimiento_All";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //solicitud
                    int idMaquina = dr.GetInt32(0);
                    string nombre = dr.GetString(1).Trim();
                    string area = dr.GetString(2).Trim();


                    maquinas Maquinas = new maquinas(
                   idMaquina,
                    nombre,
                    area
                        );

                    lista.Add(Maquinas);
                }
                dr.Close();
                conn.Close();
            }
            return lista;
        }

        public bool addMaquinas(maquinas Maquinas)
        {
            bool res = false;
            string strConn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                cmd.CommandText = "MaquinasMantenimientoAdd";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Maquinas.nombre);
                cmd.Parameters.AddWithValue("@area", Maquinas.area);
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
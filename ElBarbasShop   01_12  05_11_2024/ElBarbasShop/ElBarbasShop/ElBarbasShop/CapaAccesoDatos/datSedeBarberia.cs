using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaAccesoDatos
{
    public class datSedeBarberia
    {
        #region Singleton
        // Variable estática para la instancia
        private static readonly datSedeBarberia _instancia = new datSedeBarberia();

        // Privado para evitar la instanciación directa
        public static datSedeBarberia Instancia
        {
            get
            {
                return datSedeBarberia._instancia;
            }
        }
        #endregion Singleton

        #region Métodos

        // Método para listar barberías
        public List<entBarberia> ListarBarberia()
        {
            SqlCommand cmd = null;
            List<entBarberia> lista = new List<entBarberia>();
            
            try
            {
                 SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaBarberia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entBarberia barberia = new entBarberia
                    {
                        idBarberia = dr["idBarberia"].ToString(),
                        nombre = dr["nombre"].ToString(),
                        ubicacion = dr["ubicacion"].ToString()
                    };
                    lista.Add(barberia);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();


            }
            return lista;
        }

        // Método para insertar barbería
        public Boolean InsertarBarberia(entBarberia barberia)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaBarberia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBarberia", barberia.idBarberia);
                cmd.Parameters.AddWithValue("@nombre", barberia.nombre);
                cmd.Parameters.AddWithValue("@ubicacion", barberia.ubicacion);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();


            }
            return inserta;
        }

        // Método para editar barbería
        public Boolean EditarBarberia(entBarberia barberia)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaBarberia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBarberia", barberia.idBarberia);
                cmd.Parameters.AddWithValue("@nombre", barberia.nombre);
                cmd.Parameters.AddWithValue("@ubicacion", barberia.ubicacion);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();

            }
            return edita;
        }

        // Método para deshabilitar barbería
        public Boolean DeshabilitarBarberia(entBarberia barberia)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaBarberia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBarberia", barberia.idBarberia);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {

                cmd.Connection.Close();


            }
            return delete;
        }

        #endregion Métodos

        // Método para buscar una barbería por ID
        public entBarberia BuscarBarberiaPorId(string idBarberia)
        {
            SqlCommand cmd = null;
            entBarberia barberia = null;
            
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscaBarberia", cn); // Asegúrate de que este nombre coincida con el procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idBarberia", idBarberia);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    barberia = new entBarberia
                    {
                        idBarberia = dr["idBarberia"].ToString(),
                        nombre = dr["nombre"].ToString(),
                        ubicacion = dr["ubicacion"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar barbería: ", e);
            }
            finally
            {

                cmd.Connection.Close();


            }
            return barberia;
        }




    }









}

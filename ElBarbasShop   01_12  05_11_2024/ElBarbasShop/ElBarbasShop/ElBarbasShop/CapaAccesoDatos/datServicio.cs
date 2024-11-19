using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    using CapaEntidad;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    public class datServicio
    {
        #region Singleton
        private static readonly datServicio _instancia = new datServicio();
        public static datServicio Instancia => _instancia;
        #endregion Singleton

        #region Métodos

        // Listar Servicios
        public List<entServicio> ListarServicios()
        {
            SqlCommand cmd = null;
            List<entServicio> lista = new List<entServicio>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaServicio", cn); // Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entServicio servicio = new entServicio
                    {
                        idServicio = dr["idServicio"].ToString(),
                        nombreServicio = dr["nombreServicio"].ToString(),
                        duracion = Convert.ToInt32(dr["duracion"]),
                        precio = Convert.ToDecimal(dr["precio"])
                    };
                    lista.Add(servicio);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar servicios: ", e);
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return lista;
        }

        // Insertar Servicio
        public bool InsertarServicio(entServicio servicio)
        {
            SqlCommand cmd = null;
            bool insertado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaServicio", cn); // Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idServicio", servicio.idServicio);
                cmd.Parameters.AddWithValue("@nombreServicio", servicio.nombreServicio);
                cmd.Parameters.AddWithValue("@duracion", servicio.duracion);
                cmd.Parameters.AddWithValue("@precio", servicio.precio);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                insertado = i > 0;
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar servicio: ", e);
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return insertado;
        }

        // Editar Servicio
        public bool EditarServicio(entServicio servicio)
        {
            SqlCommand cmd = null;
            bool editado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaServicio", cn); // Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idServicio", servicio.idServicio);
                cmd.Parameters.AddWithValue("@nombreServicio", servicio.nombreServicio);
                cmd.Parameters.AddWithValue("@duracion", servicio.duracion);
                cmd.Parameters.AddWithValue("@precio", servicio.precio);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                editado = i > 0;
            }
            catch (Exception e)
            {
                throw new Exception("Error al editar servicio: ", e);
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return editado;
        }

        // Eliminar Servicio
        public bool EliminarServicio(string idServicio)
        {
            SqlCommand cmd = null;
            bool eliminado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaServicio", cn); // Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idServicio", idServicio);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                eliminado = i > 0;
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar servicio: ", e);
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return eliminado;
        }

        // Buscar Servicio por ID
        public entServicio BuscarServicioPorId(string idServicio)
        {
            SqlCommand cmd = null;
            entServicio servicio = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarServicio", cn); // Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idServicio", idServicio);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    servicio = new entServicio
                    {
                        idServicio = dr["idServicio"].ToString(),
                        nombreServicio = dr["nombreServicio"].ToString(),
                        duracion = Convert.ToInt32(dr["duracion"]),
                        precio = Convert.ToDecimal(dr["precio"])
                    };
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar servicio: ", e);
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return servicio;
        }

        #endregion Métodos
    }
}

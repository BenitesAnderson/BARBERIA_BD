using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class datTelefonoEmpleado
    {
        #region Singleton
        private static readonly datTelefonoEmpleado _instancia = new datTelefonoEmpleado();
        public static datTelefonoEmpleado Instancia => _instancia;
        #endregion Singleton

        #region Métodos

        // Listado de Teléfonos de Empleados
        public List<entTelefonoEmpleado> ListarTelefonoEmpleado(string idEmpleado)
        {
            SqlCommand cmd = null;
            List<entTelefonoEmpleado> lista = new List<entTelefonoEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaTelefonoEmpleado", cn);  // Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTelefonoEmpleado telEmp = new entTelefonoEmpleado
                    {
                        idEmpleado = dr["idEmpleado"].ToString(),
                        numeroTelefono = dr["numeroTelefono"].ToString(),
                        operador = dr["operador"].ToString()
                    };
                    lista.Add(telEmp);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar teléfonos de empleados: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        // Insertar Teléfono de Empleado
        public bool InsertarTelefonoEmpleado(entTelefonoEmpleado telEmp)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaTelefonoEmpleado", cn);  // Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", telEmp.idEmpleado);
                cmd.Parameters.AddWithValue("@numeroTelefono", telEmp.numeroTelefono);
                cmd.Parameters.AddWithValue("@operador", telEmp.operador);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
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

        // Editar Teléfono de Empleado
        public bool EditarTelefonoEmpleado(entTelefonoEmpleado telEmp)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaTelefonoEmpleado", cn);  // Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", telEmp.idEmpleado);
                cmd.Parameters.AddWithValue("@numeroTelefono", telEmp.numeroTelefono);
                cmd.Parameters.AddWithValue("@operador", telEmp.operador);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al editar teléfono de empleado: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }

        // Eliminar Teléfono de Empleado
        public bool EliminarTelefonoEmpleado(entTelefonoEmpleado telEmp)
        {
            SqlCommand cmd = null;
            bool eliminado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaTelefonoEmpleado", cn);  // Nombre del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", telEmp.idEmpleado);
                cmd.Parameters.AddWithValue("@numeroTelefono", telEmp.numeroTelefono);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) eliminado = true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar teléfono de empleado: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return eliminado;
        }

        // Método para buscar un teléfono de empleado por idEmpleado y numeroTelefono
        public entTelefonoEmpleado BuscarTelefonoEmpleado(string idEmpleado, string numeroTelefono)
        {
            SqlCommand cmd = null;
            entTelefonoEmpleado telefonoEmpleado = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarTelefonoEmpleado", cn); // Procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cmd.Parameters.AddWithValue("@numeroTelefono", numeroTelefono);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    telefonoEmpleado = new entTelefonoEmpleado
                    {
                        idEmpleado = dr["idEmpleado"].ToString(),
                        numeroTelefono = dr["numeroTelefono"].ToString(),
                        operador = dr["operador"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar teléfono del empleado: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return telefonoEmpleado;
        }

        #endregion Métodos
    }
}

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


    public class datEmpleado
    {
        #region Singleton
        private static readonly datEmpleado _instancia = new datEmpleado();
        public static datEmpleado Instancia => _instancia;
        #endregion Singleton

        #region Métodos

        // Listado de Empleados
        public List<entEmpleado> ListarEmpleado()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaEmpleado", cn);  // Asegúrate de que este nombre coincida
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado emp = new entEmpleado
                    {
                        idEmpleado = dr["idEmpleado"].ToString(),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        dni = dr["dni"].ToString(),
                        correo = dr["correo"].ToString(),
                        cargo = dr["cargo"].ToString(),
                        idBarberia = dr["idBarberia"].ToString()
                       
                    };
                    lista.Add(emp);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar empleados: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        // Insertar Empleado
        public bool InsertarEmpleado(entEmpleado emp)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaEmpleado", cn);  // Verifica el nombre aquí
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", emp.idEmpleado);
                cmd.Parameters.AddWithValue("@nombres", emp.nombres);
                cmd.Parameters.AddWithValue("@apellidos", emp.apellidos);
                cmd.Parameters.AddWithValue("@dni", emp.dni);
                cmd.Parameters.AddWithValue("@idBarberia", emp.idBarberia);
                cmd.Parameters.AddWithValue("@correo", emp.correo);
                cmd.Parameters.AddWithValue("@cargo", emp.cargo);
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

        // Editar Empleado
        public bool EditarEmpleado(entEmpleado emp)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaEmpleado", cn);  // Verifica el nombre aquí
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", emp.idEmpleado);
                cmd.Parameters.AddWithValue("@nombres", emp.nombres);
                cmd.Parameters.AddWithValue("@apellidos", emp.apellidos);
                cmd.Parameters.AddWithValue("@dni", emp.dni);
                cmd.Parameters.AddWithValue("@idBarberia", emp.idBarberia);
                cmd.Parameters.AddWithValue("@correo", emp.correo);
                cmd.Parameters.AddWithValue("@cargo", emp.cargo);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al editar empleado: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }

        // Deshabilitar Empleado
        public bool DeshabilitarEmpleado(entEmpleado emp)
        {
            SqlCommand cmd = null;
            bool deshabilitado = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaEmpleado", cn);  // Verifica el nombre aquí
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", emp.idEmpleado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) deshabilitado = true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al deshabilitar empleado: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
                return deshabilitado;
        }

        #endregion Métodos







        // Método para buscar un empleado por ID
        public entEmpleado BuscarEmpleadoPorId(string idEmpleado)
        {
            SqlCommand cmd = null;
            entEmpleado empleado = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarEmpleado", cn); // Asegúrate de que este nombre coincida con el procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    empleado = new entEmpleado
                    {
                        idEmpleado = dr["idEmpleado"].ToString(),
                        nombres = dr["nombres"].ToString(),
                        apellidos = dr["apellidos"].ToString(),
                        dni = dr["dni"].ToString(),
                        correo = dr["correo"].ToString(),
                        cargo = dr["cargo"].ToString(),
                        idBarberia = dr["idBarberia"].ToString()
                        
                    };
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar empleado: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return empleado;
        }







    }
}

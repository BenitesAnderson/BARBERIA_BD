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
    
        public class datTelefonoCliente
        {
            #region Singleton
            private static readonly datTelefonoCliente _instancia = new datTelefonoCliente();
            public static datTelefonoCliente Instancia => _instancia;
        #endregion Singleton

        #region Métodos

        // Listar Teléfonos

            public List<entTelefonoCliente> ListarTelefonoCliente()
            {
                SqlCommand cmd = null;
                List<entTelefonoCliente> lista = new List<entTelefonoCliente>();
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("spListaTelefonoCliente", cn); // Nombre del procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        entTelefonoCliente telefonoCliente = new entTelefonoCliente
                        {
                            idCliente = dr["idCliente"].ToString(),
                            numeroTelefono = dr["numeroTelefono"].ToString(),
                            operador = dr["operador"].ToString() // Asegúrate de que este campo exista
                        };
                        lista.Add(telefonoCliente);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al listar teléfonos de cliente: ", e);
                }
                finally
                {
                    cmd?.Connection.Close();
                }
                return lista;
            }

            // Insertar Teléfono
            public bool InsertarTelefono(entTelefonoCliente telefono)
            {
                SqlCommand cmd = null;
                bool inserta = false;
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("spInsertaTelefonoCliente", cn); // Nombre del procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCliente", telefono.idCliente);
                    cmd.Parameters.AddWithValue("@numeroTelefono", telefono.numeroTelefono);
                    cmd.Parameters.AddWithValue("@operador", telefono.operador);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    inserta = i > 0;
                }
                catch (Exception e)
                {
                    throw new Exception("Error al insertar teléfono: ", e);
                }
                finally
                {
                    cmd.Connection.Close();
                }
                return inserta;
            }

            // Eliminar Teléfono
            public bool EliminarTelefono(string idCliente, string numeroTelefono)
            {
                SqlCommand cmd = null;
                bool elimina = false;
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("spEliminaTelefonoCliente", cn); // Nombre del procedimiento almacenado
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    cmd.Parameters.AddWithValue("@numeroTelefono", numeroTelefono);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    elimina = i > 0;
                }
                catch (Exception e)
                {
                    throw new Exception("Error al eliminar teléfono: ", e);
                }
                finally
                {
                    cmd.Connection.Close();
                }
                return elimina;
            }
        // Editar Teléfono
          public bool EditarTelefono(entTelefonoCliente telefono)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaTelefono", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", telefono.idCliente);
                cmd.Parameters.AddWithValue("@numeroTelefono", telefono.numeroTelefono);
                cmd.Parameters.AddWithValue("@operador", telefono.operador);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al editar teléfono: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }

        // Buscar Teléfono por ID Cliente y Número
        public entTelefonoCliente BuscarTelefono(string idCliente, string numeroTelefono)
        {
            SqlCommand cmd = null;
            entTelefonoCliente telefono = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarTelefonoCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                cmd.Parameters.AddWithValue("@numeroTelefono", numeroTelefono);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    telefono = new entTelefonoCliente
                    {
                        idCliente = dr["idCliente"].ToString(),
                        numeroTelefono = dr["numeroTelefono"].ToString(),
                        operador = dr["operador"].ToString()
                    };
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar teléfono: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return telefono;
        }





        #endregion Métodos

    }



    
}

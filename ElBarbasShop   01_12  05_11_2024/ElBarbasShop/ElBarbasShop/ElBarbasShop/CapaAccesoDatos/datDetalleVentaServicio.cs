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
    public class datDetalleVentaServicio
    {

        #region Singleton
        private static readonly datDetalleVentaServicio _instancia = new datDetalleVentaServicio();
        public static datDetalleVentaServicio Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton
        #region Metodos        
        // Listado de Venta
        public List<entDetalleVentaServicio> ListarDetalleVentaServicio()
        {
            SqlCommand cmd = null;
            List<entDetalleVentaServicio> lista = new List<entDetalleVentaServicio>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaDetalleVentaServicio", cn);  // Asegúrate de que este nombre coincida
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetalleVentaServicio emp = new entDetalleVentaServicio
                    {
                        idDetalle = Convert.ToInt32(dr["idDetalle"]),
                        IdVenta = dr["idVenta"].ToString(),                        
                        IdServicio = dr["idServicio"].ToString()
                        
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
        // Insertar Cliente
        public Boolean InsertarDetalleVentaServicio(entDetalleVentaServicio DetalleVentaServicio)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaDetalleVentaServicio", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idDetalle", DetalleVentaServicio.idDetalle);
                cmd.Parameters.AddWithValue("@idVenta", DetalleVentaServicio.idVenta.IdVenta);
                cmd.Parameters.AddWithValue("@idProducto", DetalleVentaServicio.idServicio.IdServicio);

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
        //Buscar por ID 
        public entDetalleVentaServicio BuscarDetalleVentaServicioPorId(string idDetalleVentaServicio)
        {
            SqlCommand cmd = null;
            entDetalleVentaServicio emp = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarDetalleVentaServicio", cn); // Asegúrate de que este nombre coincida con el procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalle", idDetalleVentaServicio);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp = new entDetalleVentaServicio
                    {
                        idDetalle = Convert.ToInt32(dr["idDetalle"]),
                        idVenta = dr["idVenta"].ToString(),
                        idServicio = dr["idServicio"].ToString()

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
            return emp;
        }
        //editar
        public Boolean EditarDetalleVentaServicio(entDetalleVentaServicio DetalleVentaServicio)
        {
            SqlCommand cmd = null;
            Boolean edita = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDetalleVentaServicio", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalle", DetalleVentaServicio.idDetalle);
                cmd.Parameters.AddWithValue("@idVenta", DetalleVentaServicio.idVenta.IdVenta);
                cmd.Parameters.AddWithValue("@idServicio", DetalleVentaServicio.idServicio.IdServicio);

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
        #endregion Metodos
    }
}

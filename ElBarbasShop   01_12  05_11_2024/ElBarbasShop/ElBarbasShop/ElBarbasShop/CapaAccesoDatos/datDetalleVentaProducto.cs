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
    public class datDetalleVentaProducto
    {

        #region Singleton
        private static readonly datDetalleVentaProducto _instancia = new datDetalleVentaProducto();
        public static datDetalleVentaProducto Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton
        // Listado de Venta
        public List<entDetalleVentaProducto> ListarDetalleVentaProducto()
        {
            SqlCommand cmd = null;
            List<entDetalleVentaProducto> lista = new List<entDetalleVentaProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDetalleVentaProducto", cn);  // Asegúrate de que este nombre coincida
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetalleVentaProducto emp = new entDetalleVentaProducto
                    {
                        idDetalle = Convert.ToInt32(dr["idDetalle"]),
                        cantidad = Convert.ToInt32(dr["cantidad"]),
                        idProducto = new entProducto
                        {
                            IdProducto = dr["idProducto"].ToString()
                        },
                        idVenta = new entVenta
                        {
                            IdVenta = dr["idVenta"].ToString()
                        }
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
        public Boolean InsertarDetalleVentaProducto(entDetalleVentaProducto DetalleVentaProducto)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaDetalleVentaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idDetalle", DetalleVentaProducto.idDetalle);
                cmd.Parameters.AddWithValue("@cantidad", DetalleVentaProducto.cantidad);
                cmd.Parameters.AddWithValue("@idVenta", DetalleVentaProducto.idVenta.IdVenta);
                cmd.Parameters.AddWithValue("@idProducto", DetalleVentaProducto.idProducto.IdProducto);

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
        public entDetalleVentaProducto BuscarDetalleVentaProductoPorId(string idDetalleVentaProducto)
        {
            SqlCommand cmd = null;
            entDetalleVentaProducto emp = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarDetalleVentaProducto", cn); // Asegúrate de que este nombre coincida con el procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalle", idDetalleVentaProducto);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    emp = new entDetalleVentaProducto
                    {
                        idDetalle = Convert.ToInt32(dr["idDetalle"]),
                        cantidad = Convert.ToInt32(dr["cantidad"]),
                        IdProducto = dr["idProducto"].ToString(),
                        IdVenta = dr["idVenta"].ToString(),
                        
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
        //Editar
        public Boolean EditarDetalleVentaProducto(entDetalleVentaProducto DetalleVentaProducto)
        {
            SqlCommand cmd = null;
            Boolean edita = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaDetalleVentaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalle", DetalleVentaProducto.idDetalle);
                cmd.Parameters.AddWithValue("@cantidad", DetalleVentaProducto.cantidad);
                cmd.Parameters.AddWithValue("@idVenta", DetalleVentaProducto.idVenta.IdVenta);
                cmd.Parameters.AddWithValue("@idProducto", DetalleVentaProducto.idProducto.IdProducto);

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
        //Deshabilitar
        public Boolean DeshabilitarDetalleVentaProducto(entDetalleVentaProducto DetalleVentaProducto)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarDetalleVentaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDetalle", DetalleVentaProducto.idDetalle;

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) deshabilita = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return deshabilita;
        }
    }
}

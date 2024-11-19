using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaAccesoDatos
{
    public class datVenta
    {
        #region Singleton
        private static readonly datVenta _instancia = new datVenta();
        public static datVenta Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton

        #region Metodos

        // Listado de Venta
        public List<entVenta> ListarVenta()
        {
            SqlCommand cmd = null;
            List<entVenta> lista = new List<entVenta>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entVenta emp = new entVenta
                    {
                        IdVenta = dr["idVenta"].ToString(),
                        FechaVenta = Convert.ToDateTime(dr["fechaVenta"]),
                        Monto = Convert.ToDecimal(dr["monto"]),
                        IdCliente = dr["idCliente"].ToString(),
                        IdEmpleado = dr["idEmpleado"].ToString(),
                        IdMetodoPago = dr["idMetodoPago "].ToString()
                        
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

        // Buscar Venta por ID
        public entVenta BuscarVentaPorId(string idVenta)
        {
            SqlCommand cmd = null;
            entVenta vnt = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVenta", idVenta);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    vnt = new entVenta
                    {
                        IdVenta = dr["idVenta"].ToString(),
                        FechaVenta = Convert.ToDateTime(dr["fechaVenta"]),
                        Monto = Convert.ToDecimal(dr["monto"]),
                        IdCliente = dr["idCliente"].ToString(),
                        IdEmpleado = dr["idEmpleado"].ToString(),
                        IdMetodoPago = dr["idMetodoPago "].ToString()
                        
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
            return vnt;
        }

        // Insertar Venta
        public void InsertarVenta(entVenta venta)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVenta", venta.IdVenta);
                cmd.Parameters.AddWithValue("@fechaVenta", venta.FechaVenta);
                cmd.Parameters.AddWithValue("@monto", venta.Monto);
                cmd.Parameters.AddWithValue("@idCliente", venta.IdCliente);
                cmd.Parameters.AddWithValue("@idEmpleado", venta.IdEmpleado);
                cmd.Parameters.AddWithValue("@idMetodoPago", venta.IdMetodoPago);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al insertar venta: ", e);
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
        }

        // Anular Venta
        public void AnularVenta(string idVenta)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spAnulaVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVenta", idVenta);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al anular venta: ", e);
            }
            finally
            {
                if (cmd != null) cmd.Connection.Close();
            }
        }

        #endregion Metodos
    }
}

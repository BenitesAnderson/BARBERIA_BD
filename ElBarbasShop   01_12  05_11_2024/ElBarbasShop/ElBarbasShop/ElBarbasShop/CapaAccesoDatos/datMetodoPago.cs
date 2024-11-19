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
    public class datMetodoPago
    {

        #region Singleton
        private static readonly datMetodoPago _instancia = new datMetodoPago();
        public static datMetodoPago Instancia
        {
            get { return _instancia; }
        }
        #endregion Singleton

        #region Metodos

        //ListarProductos
        public List<entMetodoPago> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<entMetodoPago> lista = new List<entMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMetodoPago prod = new entMetodoPago
                    {
                        IdMetodoPago = dr["idMetodoPago"].ToString(),
                        Descripcion = dr["descripcion"].ToString()
                    };
                    lista.Add(prod);
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
        //insertar
        public Boolean InsertarMetodoPago(entMetodoPago MetodoPago)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idMetodoPago", MetodoPago.IdMetodoPago);
                cmd.Parameters.AddWithValue("@descripcion", MetodoPago.Descripcion);                

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
        //Busqueda por ID
        public entMetodoPago BuscarMetodoPagoPorId(string idMetodoPago)
        {
            SqlCommand cmd = null;
            entMetodoPago Prod = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarMetodoPagoPorID", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMetodoPago", idMetodoPago);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Prod = new entMetodoPago
                    {
                        IdMetodoPago = dr["idMetodoPago"].ToString(),
                        Descripcion = dr["descripcion"].ToString()
                    };
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
            return Prod;
        }
        //Editar
        public Boolean EditarMetodoPago(entMetodoPago MetodoPago)
        {
            SqlCommand cmd = null;
            Boolean edita = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaDetalleVentaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMetodoPago", MetodoPago.IdMetodoPago);
                cmd.Parameters.AddWithValue("@descripcion", MetodoPago.Descripcion);


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

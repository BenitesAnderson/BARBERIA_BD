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
    public class datProducto
    {
        #region Singleton
        private static readonly datProducto _instancia = new datProducto();
        public static datProducto Instancia => _instancia;
        #endregion Singleton

        #region Métodos

        // Listado de Productos
        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaProducto", cn); // Asegúrate de que el procedimiento exista
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto prod = new entProducto
                    {
                        idProducto = dr["idProducto"].ToString(),
                        nombreProducto = dr["nombreProducto"].ToString(),
                        descripcion = dr["descripcion"].ToString(),
                        precio = Convert.ToDecimal(dr["precio"]),
                        stock = Convert.ToInt32(dr["stock"])
                    };
                    lista.Add(prod);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar productos: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        // Insertar Producto
        public bool InsertarProducto(entProducto prod)
        {
            SqlCommand cmd = null;
            bool inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProducto", cn); // Verifica el nombre del procedimiento
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", prod.idProducto);
                cmd.Parameters.AddWithValue("@nombreProducto", prod.nombreProducto);
                cmd.Parameters.AddWithValue("@descripcion", prod.descripcion);
                cmd.Parameters.AddWithValue("@precio", prod.precio);
                cmd.Parameters.AddWithValue("@stock", prod.stock);
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

        // Editar Producto
        public bool EditarProducto(entProducto prod)
        {
            SqlCommand cmd = null;
            bool edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProducto", cn); // Verifica el nombre del procedimiento
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", prod.idProducto);
                cmd.Parameters.AddWithValue("@nombreProducto", prod.nombreProducto);
                cmd.Parameters.AddWithValue("@descripcion", prod.descripcion);
                cmd.Parameters.AddWithValue("@precio", prod.precio);
                cmd.Parameters.AddWithValue("@stock", prod.stock);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al editar producto: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return edita;
        }

        // Eliminar Producto
        public bool EliminarProducto(string idProducto)
        {
            SqlCommand cmd = null;
            bool elimina = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaProducto", cn); // Verifica el nombre del procedimiento
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) elimina = true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar producto: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return elimina;
        }

        // Buscar Producto por ID
        public entProducto BuscarProductoPorId(string idProducto)
        {
            SqlCommand cmd = null;
            entProducto producto = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProducto", cn); // Verifica el nombre del procedimiento
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    producto = new entProducto
                    {
                        idProducto = dr["idProducto"].ToString(),
                        nombreProducto = dr["nombreProducto"].ToString(),
                        descripcion = dr["descripcion"].ToString(),
                        precio = Convert.ToDecimal(dr["precio"]),
                        stock = Convert.ToInt32(dr["stock"])
                    };
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar producto: ", e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return producto;
        }

        #endregion Métodos
    }


}

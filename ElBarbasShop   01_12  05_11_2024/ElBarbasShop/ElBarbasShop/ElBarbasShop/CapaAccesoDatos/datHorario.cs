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
    public class datHorario
    {

        #region Singleton
        private static readonly datHorario _instancia = new datHorario();
        public static datHorario Instancia => _instancia;
        #endregion Singleton

        #region Métodos

        // Método para listar horarios
        public List<entHorario> ListarHorarios()
        {
            SqlCommand cmd = null;
            List<entHorario> lista = new List<entHorario>();

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarHorarios", cn); // Asegúrate de crear el procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entHorario horario = new entHorario
                    {
                        idEmpleado = dr["idEmpleado"].ToString(),
                        diaSemana = dr["diaSemana"].ToString(),
                        horaInicio = TimeSpan.Parse(dr["horaInicio"].ToString()),
                        horaFin = TimeSpan.Parse(dr["horaFin"].ToString())
                    };
                    lista.Add(horario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar horarios: ", ex);
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return lista;
        }

        // Método para insertar un horario
        public bool InsertarHorario(entHorario horario)
        {
            SqlCommand cmd = null;
            bool inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarHorario", cn); // Asegúrate de crear el procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", horario.idEmpleado);
                cmd.Parameters.AddWithValue("@diaSemana", horario.diaSemana);
                cmd.Parameters.AddWithValue("@horaInicio", horario.horaInicio);
                cmd.Parameters.AddWithValue("@horaFin", horario.horaFin);
                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0) inserta = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar horario: ", ex);
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return inserta;
        }

        // Método para editar un horario
        public bool EditarHorario(entHorario horario)
        {
            SqlCommand cmd = null;
            bool edita = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarHorario", cn); // Asegúrate de crear el procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", horario.idEmpleado);
                cmd.Parameters.AddWithValue("@diaSemana", horario.diaSemana);
                cmd.Parameters.AddWithValue("@horaInicio", horario.horaInicio);
                cmd.Parameters.AddWithValue("@horaFin", horario.horaFin);
                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0) edita = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar horario: ", ex);
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return edita;
        }

        // Método para eliminar un horario
        public bool EliminarHorario(string idEmpleado, string diaSemana, TimeSpan horaInicio)
        {
            SqlCommand cmd = null;
            bool elimina = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarHorario", cn); // Asegúrate de crear el procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cmd.Parameters.AddWithValue("@diaSemana", diaSemana);
                cmd.Parameters.AddWithValue("@horaInicio", horaInicio);
                cn.Open();

                int i = cmd.ExecuteNonQuery();
                if (i > 0) elimina = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar horario: ", ex);
            }
            finally
            {
                cmd?.Connection.Close();
            }
            return elimina;
        }

        // Método para buscar horarios por empleado

        public entHorario BuscarHorariosPorEmpleado(string idEmpleado)
        {
            SqlCommand cmd = null;
            entHorario horario = null;  // Se cambió de lista a un solo objeto de tipo entHorario

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarHorario", cn); // Asegúrate de crear el procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) // Cambiado de while a if para obtener solo el primer resultado
                {
                    horario = new entHorario
                    {
                        idEmpleado = dr["idEmpleado"].ToString(),
                        diaSemana = dr["diaSemana"].ToString(),
                        horaInicio = TimeSpan.Parse(dr["horaInicio"].ToString()),
                        horaFin = TimeSpan.Parse(dr["horaFin"].ToString())
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar horarios: ", ex);
            }
            finally
            {
                cmd?.Connection.Close();
            }

            return horario;  // Ahora devuelve un solo objeto entHorario o null si no se encontró
        }


        #endregion Métodos






    }
}

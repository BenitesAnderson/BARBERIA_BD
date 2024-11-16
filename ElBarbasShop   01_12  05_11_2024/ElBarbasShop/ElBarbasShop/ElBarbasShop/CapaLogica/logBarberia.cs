using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaEntidad; 



namespace CapaLogica
{
    public  class logBarberia
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logBarberia _instancia = new logBarberia();
        //privado para evitar la instanciación directa
        public static logBarberia Instancia
        {
            get
            {
                return logBarberia._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entBarberia> ListarBarberia()
        {
            return datSedeBarberia.Instancia.ListarBarberia();
        }
        ///inserta
        public void InsertaBarberia(entBarberia Cli)
        {
            datSedeBarberia.Instancia.InsertarBarberia(Cli);
        }

        //edita
        public void EditaBarberia(entBarberia Cli)
        {
            datSedeBarberia.Instancia.EditarBarberia(Cli);
        }
        public void DeshabilitarCliente(entBarberia Cli)
        {
            datSedeBarberia.Instancia.DeshabilitarBarberia(Cli);
        }
        #endregion metodos

        public entBarberia BuscarBarberiaPorId(string idBarberia)
        {
            return datSedeBarberia.Instancia.BuscarBarberiaPorId(idBarberia);
        }



    }









}


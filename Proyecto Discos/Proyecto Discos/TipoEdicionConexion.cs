using Proyecto_Discos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discos
{
    internal class TipoEdicionConexion
    {
        public List<TipoEdicion> listar()
        {
            List<TipoEdicion> lista = new List<TipoEdicion>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM TIPOSEDICION");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TipoEdicion edicion = new TipoEdicion();

                    edicion.Id = (int)datos.Lector["Id"];
                    edicion.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(edicion);
                }
                return lista;

            }
            catch (Exception ex) { throw ex; }
            finally { datos.cerrarConexion(); }
        }
    }
}

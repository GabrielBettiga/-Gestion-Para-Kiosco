using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace DAO
{
    public class DAOventas
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable ListarProductos()
        {
            DataTable tabla = ds.ObtenerTabla("FACTURAS", "SELECT * FROM FACTURAS");
            return tabla;

        }



    }
}

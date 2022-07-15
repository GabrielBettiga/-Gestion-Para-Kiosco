using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using Entidades;

namespace Negocios
{
    public class NegocioVentas
    {

        public DataTable ListarVentas()
        {
            DAOventas dao = new DAOventas();
            return dao.ListarProductos();
        }





    }
}

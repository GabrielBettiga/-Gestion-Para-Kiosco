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
    public class NegocioProductos
    {
        DAOProductos daopro = new DAOProductos();


        public bool AgregarProducto(Producto producto)
        {
            int cantFilas = 0;
            DAOProductos dao = new DAOProductos();

            if (dao.ExisteProducto(producto) == false)
            {
                cantFilas = dao.AgregarProducto(producto);
            }
            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            

        }

        public DataTable ListarProductos(Paginacion obj)
        {
            DAOProductos dao = new DAOProductos();
            return dao.ListarProductos(obj);
        }

        public DataTable BuscarProductoPorID(string ID)
        {
            DAOProductos dao = new DAOProductos();
            return dao.BuscarProductoPorID(ID);
        }

 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace Negocios
{
    public class NegocioProductos
    {
        public DataTable getListaPeoductos()
        {
            DAOProductos dao = new DAOProductos();
            return dao.getListaPeoductos();
        }

        //public bool EliminarSucursal(int id)
        //{
        //    DaoSucursales dao = new DaoSucursales();
        //    Sucursales suc = new Sucursales();
        //    suc.IdSucursal = id;
        //    int op = dao.EliminarSucursal(suc);
        //    if (op == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool AgregarSucursal(string nombre)
        //{
        //    int cantFilas = 0;
        //    Sucursales suc = new Sucursales();
        //    suc.NombreSucursal = nombre;
        //    DaoSucursales dao = new DaoSucursales();
        //    if (dao.ExisteSucursal(suc) == false)
        //    {
        //        cantFilas = dao.AgregarSucursal(suc);
        //    }
        //    if (cantFilas == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}

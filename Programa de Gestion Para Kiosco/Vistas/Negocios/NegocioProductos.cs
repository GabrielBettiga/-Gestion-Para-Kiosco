﻿using System;
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

        public DataSet ListarClientes(Paginacion obj)
        {
            return daopro.ListarClientes(obj);
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

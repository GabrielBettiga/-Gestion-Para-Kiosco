using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace DAO
{
    public class DAOProductos
    {
        AccesoDatos conexion = new AccesoDatos();

        AccesoDatos ds = new AccesoDatos();

        public DataTable ListarProductos(Paginacion obj)
        {
            DataTable tabla = ds.ObtenerTabla("Productos", "SELECT * FROM PRODUCTOS WHERE  Numero_P between 1 and 10");
            return tabla;

        }

        //public Sucursales getSucursal(Sucursales suc)
        //{
        //    DataTable tabla = ds.ObtenerTabla("Sucursal", "SELECT * FROM Sucursal WHERE Id_Sucursal=" + suc.IdSucursal);
        //    suc.IdSucursal = Convert.ToInt32(tabla.Rows[0][0].ToString());
        //    suc.NombreSucursal = (tabla.Rows[0][1].ToString());
        //    suc.DescripcionSucursal = (tabla.Rows[0][2].ToString());
        //    return suc;
        //}
        //public Boolean ExisteSucursal(Sucursales suc)
        //{
        //    string consulta = "SELECT * FROM Sucursal WHERE NombreSucursal = '" + suc.NombreSucursal + "'";
        //    return ds.Existe(consulta);
        //}
        //public DataTable getListaPeoductos()
        //{
        //    DataTable tabla = ds.ObtenerTabla("Productos", "SELECT ID_Producto_P AS [Codigo Producto], Descripcion_P AS [Descripcion], Categoria_P AS [Categoria], Stock_P AS [Stock], Punto_De_Pedido_P AS [Punto Pedido], Porcentaje_De_Venta_P AS [Porcentaje de Venta], Estado_P AS [Estado] FROM Productos");
        //    return tabla;
        //}

        //public int EliminarSucursal(Sucursales suc)
        //{
        //    SqlCommand comando = new SqlCommand();
        //    ArmarParametrosSucursalEliminar(ref comando, suc);
        //    return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarCategoria");
        //}
        //public int AgregarSucursal(Sucursales suc)
        //{
        //    suc.IdSucursal = ds.ObtenerMaximo("SELECT MAX(Id_Sucursal) FROM Sucursal") + 1;
        //    SqlCommand comando = new SqlCommand();
        //    ArmarParametrosSucursalAgregar(ref comando, suc);
        //    return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        //}
        //private void ArmarParametrosSucursalEliminar(ref SqlCommand comando, Sucursales suc)
        //{
        //    SqlParameter SqlParametros = new SqlParameter();
        //    SqlParametros = comando.Parameters.Add("@IDSUCURSAL", SqlDbType.Int);
        //    SqlParametros.Value = suc.IdSucursal;
        //}
        //private void ArmarParametrosSucursalAgregar(ref SqlCommand comando, Sucursales suc)
        //{
        //    SqlParameter SqlParametros = new SqlParameter();
        //    SqlParametros = comando.Parameters.Add("@IDSUCURSAL", SqlDbType.Int);
        //    SqlParametros.Value = suc.IdSucursal;
        //    SqlParametros = comando.Parameters.Add("@NOMBRESUCURSAL", SqlDbType.VarChar);
        //    SqlParametros.Value = suc.NombreSucursal;
        //    SqlParametros = comando.Parameters.Add("@DESCRIPCIONSUCURSAL", SqlDbType.VarChar);
        //    SqlParametros.Value = suc.DescripcionSucursal;
        //}
    }
}

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


        public int AgregarProducto(Producto producto)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosFuncionAgregar(ref comando, producto);
            return ds.EjecutarProcedimientoAlmacenado(comando, "sp_AgregarProducto");
        }

        public DataTable ListarProductos    (Paginacion obj)
        {
            DataTable tabla = ds.ObtenerTabla("Productos", "SELECT * FROM PRODUCTOS WHERE  Numero_P between "+obj.VarDatoInicio1+" and "+obj.VarDatoFin1);
            return tabla;

        }

        public DataTable BuscarProductoPorID(string ID)
        {
            DataTable tabla = ds.ObtenerTabla("PRODUCTOS", "Select ID_Producto_P, Categoria_P, Descripcion_P, Stock_P, Punto_De_Pedido_P, Porcentaje_De_Venta_P, Estado_P  FROM PRODUCTOS WHERE ID_Producto_P = '" + ID + "'");
            return tabla;

        }

        private void ArmarParametrosFuncionAgregar(ref SqlCommand comando, Producto producto)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@IDPRODUCTO", SqlDbType.VarChar);
            SqlParametros.Value = producto.ID_Producto_P1;
            SqlParametros = comando.Parameters.Add("@CATEGORIA", SqlDbType.VarChar);
            SqlParametros.Value = producto.Categoria_P1;
            SqlParametros = comando.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar);
            SqlParametros.Value = producto.Descripcion_P1;
            SqlParametros = comando.Parameters.Add("@STOCK", SqlDbType.Int);
            SqlParametros.Value = producto.Stock_P1;
            SqlParametros = comando.Parameters.Add("@PUNTODEPEDIDO", SqlDbType.Int);
            SqlParametros.Value = producto.Punto_De_Pedido_P1;
            SqlParametros = comando.Parameters.Add("@PORCENTAJEDEVENTA", SqlDbType.Decimal);
            SqlParametros.Value = producto.Porcentaje_De_Venta_P1;
            SqlParametros = comando.Parameters.Add("@URL", SqlDbType.VarChar);
            SqlParametros.Value = producto.URL1;

        }


    }
}

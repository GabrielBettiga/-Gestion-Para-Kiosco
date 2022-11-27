using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int Numero_P;
        private string ID_Producto_P;
        private string Categoria_P;
        private string Descripcion_P;
        private int Stock_P;
        private int Punto_De_Pedido_P;
        private decimal Porcentaje_De_Venta_P;
        private string URL;
        private bool Estado_P;

        public Producto() { }

        public int Numero_P1 { get => Numero_P; set => Numero_P = value; }
        public string ID_Producto_P1 { get => ID_Producto_P; set => ID_Producto_P = value; }
        public string Categoria_P1 { get => Categoria_P; set => Categoria_P = value; }
        public string Descripcion_P1 { get => Descripcion_P; set => Descripcion_P = value; }
        public int Stock_P1 { get => Stock_P; set => Stock_P = value; }
        public int Punto_De_Pedido_P1 { get => Punto_De_Pedido_P; set => Punto_De_Pedido_P = value; }
        public decimal Porcentaje_De_Venta_P1 { get => Porcentaje_De_Venta_P; set => Porcentaje_De_Venta_P = value; }
        public bool Estado_P1 { get => Estado_P; set => Estado_P = value; }
        public string URL1 { get => URL; set => URL = value; }
    }
}

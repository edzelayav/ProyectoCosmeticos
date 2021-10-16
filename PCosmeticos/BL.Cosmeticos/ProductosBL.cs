using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Cosmeticos
{
   public class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Agua micelar en aceite de Garnier";
            producto1.Precio = 385;
            producto1.Existencia = 15;
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Agua micelar de Uriage";
            producto2.Precio = 670;
            producto2.Existencia = 10;
            producto2.Activo = true;

            ListaProductos.Add(producto2);

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Dispositivo de limpieza facial de Foreo";
            producto3.Precio = 1376;
            producto3.Existencia = 10;
            producto3.Activo = true;

            ListaProductos.Add(producto3);

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Mascara L'Oréal Voluminous Butterfly Blackest Black";
            producto4.Precio = 441.90;
            producto4.Existencia = 20;
            producto4.Activo = true;

            ListaProductos.Add(producto4);

            var producto5 = new Producto();
            producto5.Id = 5;
            producto5.Descripcion = "Jabon facial Neutrogena";
            producto5.Precio = 282.90;
            producto5.Existencia = 20;
            producto5.Activo = true;

            ListaProductos.Add(producto5);

            var producto6 = new Producto();
            producto6.Id = 6;
            producto6.Descripcion = "Crema facial Nivea 20ml";
            producto6.Precio = 27.90;
            producto6.Existencia = 30;
            producto6.Activo = true;

            ListaProductos.Add(producto6);

            var producto7 = new Producto();
            producto7.Id = 7;
            producto7.Descripcion = "Exfoliante facial Garnier";
            producto7.Precio = 264.78;
            producto7.Existencia = 15;
            producto7.Activo = true;

            ListaProductos.Add(producto7);

            var producto8 = new Producto();
            producto8.Id = 8;
            producto8.Descripcion = "Crema facial - L'Oréal Paris";
            producto8.Precio = 395;
            producto8.Existencia = 15;
            producto8.Activo = true;

            ListaProductos.Add(producto8);
        }

        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }
    }
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }


    }

}

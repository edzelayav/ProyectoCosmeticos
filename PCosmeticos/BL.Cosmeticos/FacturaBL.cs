using BL.Cosmeticos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Cosmeticos
{
  public   class FacturaBL
        {
            Contexto _contexto;

            public BindingList<Factura> ListaFacturas { get; set; }

            public FacturaBL()
            {
                _contexto = new Contexto();
            }
            public BindingList<Factura> ObtenerFacturas()
            {
                _contexto.Facturas.Include("FacturaDetalle").Load();
                ListaFacturas = _contexto.Facturas.Local.ToBindingList();

                return ListaFacturas;
            }
            public void AgregarFactura()
            {
                var nuevaFactura = new Factura();
                _contexto.Facturas.Add(nuevaFactura);
            }
        public void AgregarFacturaDetalle(Factura factura) // agrega datos en la factura 
        {
            if (factura != null)
            {
                var nuevoDetalle = new FacturaDetalle();
                factura.FacturaDetalle.Add(nuevoDetalle);
            }
        }
        public void RemoverFacturaDetalle(Factura factura, FacturaDetalle facturaDetalle) // remueve los datos en la factura 
        {
            if ( factura != null && facturaDetalle != null)
            {
                factura.FacturaDetalle.Remove(facturaDetalle);

            }
        }

            public void CancelarCambios() // funcion de cancelar
            {
                foreach (var item in _contexto.ChangeTracker.Entries())
                {
                    item.State = EntityState.Unchanged;
                    item.Reload();

                }
            }
            public Resultado GuardarFactura(Factura factura) //funcion de guadar
            {
                var resultado = validar(factura);
                if (resultado.Exitoso == false)
                {
                    return resultado;
                }
                 _contexto.SaveChanges();
                resultado.Exitoso = true;
                return resultado;
            }
            private void CalcularExistencia(Factura factura) // calcula la existencia del producto
        {
            foreach (var detalle in factura.FacturaDetalle)
            {
                var producto = _contexto.Productos.Find(detalle.Productoid);
                if (producto != null)
                {
                    if (factura.Activo == true)
                    { 
                    producto.Existencia = producto.Existencia - detalle.Cantidad;
                    }
                    else
                    {
                        producto.Existencia = producto.Existencia + detalle.Cantidad;
                    }
                }
            }
        }


            private Resultado validar(Factura factura) // funcion de validacion 
            {
                var resultado = new Resultado();
                resultado.Exitoso = true;
            

             if (factura == null)
            {
                resultado.Mensaje = "Agregue una Factura para salvarla.";
                resultado.Exitoso = false;

                return resultado;
            }

            if (factura.id !=0 &&factura.Activo == true)
            {
                resultado.Mensaje = "La Factura ya fue emitida y no se puede hacer cambios en ella .";
                resultado.Exitoso = false;
            }

            if (factura.Activo == false)
            {
                resultado.Mensaje = "La Factura esta anulada y no se puede realizar cambio en ella.";
                resultado.Exitoso = false;
            }

             if (factura.Clienteid == 0)
            {
                resultado.Mensaje = "Seleccione un cliente.";
                resultado.Exitoso = false;
            }

             if (factura.FacturaDetalle.Count == 0)
            {
                resultado.Mensaje = "Agregue un Producto a la Factura.";
                resultado.Exitoso = false;
            
            }

             foreach (var detalle in factura.FacturaDetalle)
            {
               if (detalle.Productoid == 0)
                {
                    resultado.Mensaje = "Seleccione Productos Validos.";
                    resultado.Exitoso = false;
                }
            }

              return resultado;
            }
        
        public void CalcularFactura(Factura factura) // calcular el precio del producto en la factura 
        {
            if (factura != null)
            {
                double subtotal = 0;
                foreach ( var detalle in factura.FacturaDetalle)
                {
                    var producto = _contexto.Productos.Find(detalle.Productoid);// busca el precio del producto en la base de datos 
                    if (producto != null)
                    {
                        detalle.precio = producto.Precio;
                        detalle.total = detalle.Cantidad * producto.Precio;

                        subtotal += detalle.total;
                    }
                }
                factura.Subtotal = subtotal; // se calcula el subtotal del producto 
                factura.Impuesto = subtotal * 0.15; // se calcula el impuesto de producto 
                factura.Total = subtotal + factura.Impuesto; // se calcula el precio total de producto

            }
        }
        public bool AnularFactura(int id)
        {
            foreach ( var factura in ListaFacturas)
            {
                if (factura.id == id)
                {
                    factura.Activo = false;

                    CalcularExistencia(factura);

                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        }
        public class Factura
    {
        public int id { get; set; }
        public DateTime Fecha { get; set; }
        public int Clienteid { get; set; }
        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public  Factura()
        {
                Fecha = DateTime.Now;
                FacturaDetalle = new BindingList<FacturaDetalle>();
                Activo = true;

        }
}
              public class FacturaDetalle
{
    public int id { get; set; }
    public int Productoid { get; set; }
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }
    public double precio { get; set; }
    public double total { get; set; }

    public FacturaDetalle()
    {
        Cantidad = 1;

    }
    }
}



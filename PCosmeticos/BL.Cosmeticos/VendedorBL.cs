using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Cosmeticos
{
   public class VendedorBL
    {
        Contexto _contexto;
        public BindingList<Vendedor> ListaVendedor { get; set; }

        public VendedorBL()
        {
            _contexto = new Contexto();
            ListaVendedor = new BindingList<Vendedor>();



        }
        public BindingList<Vendedor> ObtenerVendedor()
        {
            _contexto.Vendedor.Load();
            ListaVendedor = _contexto.Vendedor.Local.ToBindingList();
            return ListaVendedor;
        }
        public Resultad GuardarVendedor(Vendedor vendedor)
        {
            var resultado = validar(vendedor);
            if (resultado.Exitoso == false)

            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;

        }

        public void AgregarVendedor()
        {
            var nuevoVendedor = new Vendedor();
            ListaVendedor.Add(nuevoVendedor);
        }

        public bool EliminarVendedor(int id)
        {
            foreach (var vendedor in ListaVendedor)
            {
                if (vendedor.Id == id)
                {
                    ListaVendedor.Remove(vendedor);
                    _contexto.SaveChanges();
                    return true;
                }

            }
            return false;
        }

        private Resultad validar(Vendedor vendedor)
        {
            var resultado = new Resultad();
            resultado.Exitoso = true;

            if (vendedor == null)
            {
                resultado.Mensaje = "Agregue un vendedor valido.";
                resultado.Exitoso = false;

                  return resultado;
            }

            if (string.IsNullOrEmpty(vendedor.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }
           
            if (string.IsNullOrEmpty(vendedor.Area) == true)
            {
                resultado.Mensaje = "Agregue una área";
                resultado.Exitoso = false;
            }


            if (string.IsNullOrEmpty(vendedor.Cargo) == true)
            {
                resultado.Mensaje = "Agregue una cargo";
                resultado.Exitoso = false;
            }



            return resultado;
        }
    }
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double celular { get; set; }
        public string Area { get; set; }
        public string Cargo { get; set; }
        public bool Activo { get; set; }

        public Vendedor()
        {
            Activo = true;
        }

    }
    public class Resultad             //Se creo la clase de Resultado//
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }


}


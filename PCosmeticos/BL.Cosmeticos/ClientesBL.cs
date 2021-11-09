using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Cosmeticos
{
    public class ClientesBL
    {
        Contexto _contexto;
        public BindingList<Cliente> ListaClientes {  get;   set;}

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Cliente>();

          

        }
        public BindingList<Cliente> ObtenerCliente()
        {
            _contexto.Clientes.Load();
            ListaClientes = _contexto.Clientes.Local.ToBindingList();
            return ListaClientes;
        }
        public resultado GuardarCliente(Cliente cliente)
        {
            var resultado = validar(cliente);
            if (resultado.Exitoso == false)

            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
            
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);
        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                }

            }
            return false;
        }

        private resultado validar(Cliente cliente)
        {
            var resultado = new resultado();
            resultado.Exitoso = true;

            if(cliente == null)
            {
                resultado.Mensaje = "Agregue un cliente valido.";
                resultado.Exitoso = false;

                    return resultado;
            }

            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }
            if (cliente.celular < 0)
            {
                resultado.Mensaje = "Por Favor ingrese un número de celular";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(cliente.Direccion) == true)
            {
                resultado.Mensaje = "Agregue una dirección";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double celular { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

    }
    public class resultado             //Se creo la clase de Resultado//
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}

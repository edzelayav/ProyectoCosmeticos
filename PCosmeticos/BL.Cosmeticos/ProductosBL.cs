﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Cosmeticos
{
   public class ProductosBL
    {
        Contexto _contexto;
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaProductos = new BindingList<Producto>();
            
        }

        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();

            return ListaProductos;
        }

        public BindingList<Producto> ObtenerProductos(string buscar)//
        {
            var resultado = _contexto.Productos.Where(r => r.Descripcion.Contains(buscar));
           

            return new BindingList<Producto>(resultado.ToList());
        }
        public Resultado GuardarProducto(Producto producto) //Creando la funcion guardar producto//
        {
            var resultado = Validar(producto);
            if(resultado.Exitoso == false)

            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()  //Creando la funcion agregar nuevo producto//
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)  //Creando la función eliminar //
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {                                       //Ciclo para buscar el producto deseado y luego ser borrado//
                    ListaProductos.Remove(producto);               //Lista para recorrer objetos//
                    _contexto.SaveChanges();
                    return true;

                }
            }
            return false;
        }

        private Resultado Validar (Producto producto)      // Función para Validaciones//

        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (producto == null)
            {
                resultado.Mensaje = "Agregue un Producto Valido.";
                resultado.Exitoso = false;

                return resultado;

            }

            if (string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripción";
                resultado.Exitoso = false;
            }
            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            if (producto.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            if (producto.TipoId == 0)
            {
                resultado.Mensaje = "Por Favor, Seleccione un tipo";
                resultado.Exitoso = false;
            }
            if (producto.CategoriaId == 0)
            {
                resultado.Mensaje = "Por Favor, Seleccione una categoria";
                resultado.Exitoso = false;
            }

                return resultado;
        }
    }
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }

        public Producto()
        {
            Activo = true;
        }

    }

    public class Resultado             //Se creo la clase de Resultado//
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }

}


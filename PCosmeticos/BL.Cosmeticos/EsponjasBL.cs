using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Cosmeticos
{
    public class EsponjasBL
    {
        public BindingList<Esponja> ListaEsponja { get; set; }
        public EsponjasBL()
        {
            ListaEsponja = new BindingList<Esponja>();

            var Esponja1 = new Esponja();
            Esponja1.Id = 1;
            Esponja1.Descripcion = "Esponja con Base";
            Esponja1.Precio = 100;
            Esponja1.Existencia = 20;
            Esponja1.Activo = true;

            ListaEsponja.Add(Esponja1);


            var Esponja2 = new Esponja();
            Esponja2.Id = 2;
            Esponja2.Descripcion = "Beauty Creations Blending Sponge w/soap";
            Esponja2.Precio = 150;
            Esponja2.Existencia = 15;
            Esponja2.Activo = true;

            ListaEsponja.Add(Esponja2);

            var Esponja3 = new Esponja();
            Esponja3.Id = 3;
            Esponja3.Descripcion = " Esponjas Puff Maquillaje Kylie Cosmetics ";
            Esponja3.Precio = 270;
            Esponja3.Existencia = 15;
            Esponja3.Activo = true;

            ListaEsponja.Add(Esponja3);


       
        }
        public BindingList<Esponja> ObtenerEsponja()
        {
            return ListaEsponja;
        }
    }

    public class Esponja
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}

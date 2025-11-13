using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    #region Punto 1
    public class Ingrediente : ICloneable
    {
        public string Nombre { get; set; }
        public Single Costo { get; set; }

        public Ingrediente(string _nombre, Single _costo)
        {
            Nombre = _nombre;
            Costo = _costo;
        }
        public object Clone()
        {
            return new Ingrediente(Nombre, Costo);
        }

    }
    #endregion 

    #region Punto 2
    public class Plato : ICloneable
    {
        private List<Ingrediente> ingredientes = new List<Ingrediente>();
        public List<Ingrediente> _ingredientes
        {
            get => ingredientes;
            set => ingredientes = value;
        }


        public void AgregarIngrediente(Ingrediente _ingrediente)
        {
            ingredientes.Add(_ingrediente);
        }

        public object Clone()
        {
            Plato clon = new Plato();

            foreach (Ingrediente X in ingredientes)
            {
                clon.ingredientes.Add((Ingrediente)X.Clone());
            }

            return clon;
        }

        public double Costo
        {
            get
            {
                double costo_total = 0;
                foreach (Ingrediente _ingrediente in ingredientes)
                {
                    costo_total += _ingrediente.Costo;
                }
                
                return costo_total;
            }
        }
    }
    #endregion

    #region Punto 3
    public abstract class Cocinero : ICocinero
    {
        internal virtual Plato PrepararPlato()
        {
            return new Plato();
        }

        Plato ICocinero.PrepararPlato()
        {
            return new Plato();
        }
    }
    #endregion

    #region Punto 4
    public class Chef : Cocinero
    {
        internal override Plato PrepararPlato()
        {
            Plato plato = new Plato();

            Ingrediente carne = new Ingrediente("Carne", 15);
            Ingrediente papa = new Ingrediente("Papa", 9);
            Ingrediente cebolla = new Ingrediente("Cebolla", 6);

            plato.AgregarIngrediente(carne);
            plato.AgregarIngrediente(carne);
            plato.AgregarIngrediente(papa);
            plato.AgregarIngrediente(papa);
            plato.AgregarIngrediente(cebolla);

            return plato;
        }
    }

    public class Repostero : Cocinero
    {
        internal override Plato PrepararPlato()
        {
            Plato plato = new Plato();

            Ingrediente azucar = new Ingrediente("Azucar", 8);
            Ingrediente harina = new Ingrediente("Harina", 4);
            Ingrediente huevo = new Ingrediente("Huevo", 3);

            plato.AgregarIngrediente(azucar);
            plato.AgregarIngrediente(azucar);
            plato.AgregarIngrediente(azucar);
            plato.AgregarIngrediente(harina);
            plato.AgregarIngrediente(harina);
            plato.AgregarIngrediente(harina);
            plato.AgregarIngrediente(huevo);
            plato.AgregarIngrediente(huevo);

            return plato;
        }
    }
    #endregion

    public interface ICocinero
    {
        Plato PrepararPlato();
    }

    #region Punto 5
    public class Restaurante
    {
        private double costo_total = 0;
        
        public Plato SacarPlato(Cocinero cocinero)
        {
            Plato plato = cocinero.PrepararPlato();
            costo_total += plato.Costo;
            return plato;
        }

        public double CostoTotal => costo_total;

        private Mesa[] mesas = { new Mesa(), new Mesa(), new Mesa() };

        public Mesa this[int numero]
        {
            get
            {
                return mesas[numero - 1];
            }
        }

        public void OrdenarPlato(int tipo)
        {
            ICocinero cocinero;

            if (tipo == 0)
                cocinero = new Repostero();
            else
                cocinero = new Repostero();
    }
        #endregion

        public class Mesa : IEnumerable<Plato>
        {
            private List<Plato> platos = new List<Plato>();




            public IEnumerator<Plato> GetEnumerator() => platos.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}

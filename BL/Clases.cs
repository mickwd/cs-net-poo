using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    #region Punto 1
    public class Ingrediente
    {
        public string Nombre { get; set; }
        public Single Costo { get; set; }

        public Ingrediente(string _nombre, Single _costo)
        {
            Nombre = _nombre;
            Costo = _costo;
        }
    }
    #endregion 

    #region Punto 2
    public class Plato
    {
        private List<Ingrediente> ingredientes = new List<Ingrediente>();

        public void AgregarIngrediente(Ingrediente _ingrediente)
        {
            ingredientes.Add(_ingrediente);
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
    public abstract class Cocinero
    {
        internal virtual Plato PrepararPlato()
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
    }
    #endregion

    public class Mesa
    {

    }
}

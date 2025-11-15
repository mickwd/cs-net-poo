using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    #region Punto 2
    public abstract class Avion : IComparable<Avion> /* Punto 12 => Para ordenarlos con .Sort debe ser 'IComparable' */
    {
        #region Punto 3
        public string Nombre { get; set; }
        public int AlturaMaxima { get; set; }
        public string Matricula { get; }
        public abstract int CalcularVelocidadMaxima(); // Para que se implemente obligatoriamente debe ser 'abstract' (por consecuencia la clase tambien tiene que serlo).
        #endregion

        #region Punto 4
        public Avion(string _matricula)
        {
            Matricula = _matricula;
        }
        #endregion

        #region Punto 9
        public bool Volando = false;
        public void Volar(bool estado)
        {
            Volando = estado;
        }
        #endregion

        #region Punto 12
        public int CompareTo(Avion x)
        {
            int valor = string.Compare(this.Matricula, x.Matricula, StringComparison.Ordinal);

            if (valor == 0)
                valor = string.Compare(this.Nombre, x.Nombre, StringComparison.Ordinal);
            
            return valor;
        }
        #endregion
    }

    public class Boeing747 : Avion
    {
        public Boeing747(string _matricula) : base(_matricula)
        {
        }

        #region Punto 5
        public override int CalcularVelocidadMaxima()
        {
            return 988;
        }
        #endregion
    }

    public class Avioneta : Avion
    {
        public Avioneta(string _matricula) : base(_matricula)
        {
        }

        #region Punto 5
        public override int CalcularVelocidadMaxima()
        {
            return 235;
        }
        #endregion
    }

    public class Planeador : Avion
    {
        public Planeador(string _matricula) : base(_matricula)
        {
        }

        #region Punto 5
        public override int CalcularVelocidadMaxima()
        {
            return 250;
        }
        #endregion
    }

    #region Punto 8
    public sealed class F19 : Avion // Se usa 'sealed' para evitar que esta clase pueda ser heredada.
    {
        #endregion
        public F19(string _matricula) : base(_matricula)
        {
        }

        #region Punto 5
        public override int CalcularVelocidadMaxima()
        {
            return 1100;
        }
        #endregion
    }

    public class Flota : IEnumerable<Avion> /* Punto 7 => Para iterar la lista 'aviones' sin exponerla */, ICloneable /* Punto 11 => Para soportar clonacion profunda */
    {
        private List<Avion> aviones = new List<Avion>();

        public IEnumerator<Avion> GetEnumerator() // Se usa 'IEnumerable' para poder iterar la coleccion de aviones sin exponer la lista 'aviones'.
        {
            return aviones.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Agregar(Avion _avion)
        {
            aviones.Add(_avion);
            VolarAviones += _avion.Volar; // Punto 9 => se suscribe el metodo Volar de cada avion al delegado VolarAviones
        }

        #region Punto 9
        public delegate void PonerEnVuelo(bool estado);
        public PonerEnVuelo VolarAviones;

        public void PonerTodoEnVuelo(bool estado)
        {
            if (VolarAviones != null)
            {
                VolarAviones(estado);
            }
        }
        #endregion

        #region Punto 10 
        public int CalcularAlturaPromedio()
        {
            return (int)aviones.Average(x => x.AlturaMaxima);
        }
        #endregion

        #region Punto 11 | La clase debe implementar 'ICloneable'
        public object Clone()
        {
            List<Avion> clon = new List<Avion>();

            foreach (Avion x in aviones)
            {
                clon.Add(x);
            }

            return clon;
        }
        #endregion

        #region Punto 12 
        public void Ordenar()
        {
            aviones.Sort(); // Se usa el metodo 'Sort' que utiliza la implementacion de 'IComparable' en la clase 'Avion'
        }
        #endregion
    }
    #endregion
}

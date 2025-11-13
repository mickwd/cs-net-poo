using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace musimundo
{
    public abstract class Electrodomestico
    {
        public string Nombre { get; set; }
        public bool Encendido = true;
        public abstract int Consumo { get; set; }

        public void Apagar(bool estado)
        {
            Encendido = estado;
        }

        public string Marca { get; internal set; }
    }

    public class Heladera : Electrodomestico, ICertificadoEPA
    {
        public string CodigoCertificacion { get; set; }
        public override sealed int Consumo
        {
            get
            {
                if (CapacidadLitros < 500)
                    return 300;
                else
                    return 350;
            }
            set => Consumo = value;
        }
        public int CapacidadLitros { get; set; }
    }

    public sealed class Televisor : Electrodomestico, ICertificadoEPA
    {
        public string CodigoCertificacion { get; set; }
        public override int Consumo
        {
            get => (100 + Pulgadas);
            set => Consumo = value;
        }
        public int Pulgadas { get; set; }
    }

    public class AireAcondicionado : Electrodomestico
    {
        public override int Consumo
        {
            get
            {
                double _consumo = 0;

                _consumo = 1000 + (Frigorias / 2);

                if (Tipo == _tipoAire.Inverter)
                    _consumo *= 0.8;

                return (int)_consumo;
            }
            set => Consumo = value;
        }
        public int Frigorias { get; set; }
        public enum _tipoAire { Inverter, Comun }
        public _tipoAire Tipo { get; set; }
    }

    public class RedElectrica : IEnumerable<Electrodomestico>, ICloneable
    {
        public object Clone()
        {
            RedElectrica clon = new RedElectrica();
            
            foreach (Electrodomestico X in this.lista_electrodomesticos)
            {
                clon.Agregar(X);
            }
            
            return clon;
        }

        private List<Electrodomestico> lista_electrodomesticos = new List<Electrodomestico>();
        public List<Electrodomestico> _lista_electrodomesticos
        {
            get => lista_electrodomesticos;
            set => lista_electrodomesticos = value;
        }

        public delegate void EventoCorteDeCorriente(bool Encendido);
        public EventoCorteDeCorriente CorteDeCorriente;

        public event EventHandler<EPAEventArgs> EventoEPA;

        public void Agregar(Electrodomestico X)
        {
            X.Marca = "ACME";
            lista_electrodomesticos.Add(X);
            CorteDeCorriente += X.Apagar;

            if (X is ICertificadoEPA certificado)
            {
                EventoEPA.Invoke(this, new EPAEventArgs(certificado.CodigoCertificacion));
            }
        }

        public void CortarCorriente()
        {
            if (CorteDeCorriente != null)
            {
                CorteDeCorriente(false);
            }
        }

        public IEnumerator<Electrodomestico> GetEnumerator()
        {
            return lista_electrodomesticos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<Televisor> ListarTelevisoresGrandes()
        {
            return lista_electrodomesticos.OfType<Televisor>().Where(tv => tv.Pulgadas > 40).ToList();
        }

    }

    public interface ICertificadoEPA
    {
        string CodigoCertificacion { get; set; }
    }

    public class EPAEventArgs : EventArgs
    {
        public string CodigoCertificacion { get; set; }

        public EPAEventArgs(string codigo)
        {
            CodigoCertificacion = codigo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Gallina
    {
        #region Punto Constructor
        public Gallina(string _color, int _edad, _enum_sexo _sexo)
        {
            Color = _color;
            Edad = _edad;
            Sexo = _sexo;
        }

        internal string _color { get; set; }
        public string Color { get { return _color; } set { _color = value; } }
        internal int _edad { get; set; }
        public int Edad { get { return _edad; } 
            set 
            {
                #region Punto Exception
                if (value < 0 || value > 15)
                {
                    GallinaException _exception = new GallinaException();
                    _exception._gallina = this;

                    throw _exception;
                }
                #endregion

                _edad = value;
            }
        }

        public enum _enum_sexo { Macho, Hembra }
        public _enum_sexo Sexo { get; set; }
        #endregion

        #region Punto alimentos
        internal int Alimentos = 0;
        internal bool _satisfecha { get; set; }
        public bool Satisfecha
        {
            get
            {
                #region Ver nota
                // if (Edad >= 3 && Alimentos >= 4) return true;
                //
                //              Esto no funcionaria por que no entraria en la condicion, entraria en la siguiente,
                //              por eso se debe corroborar primero por edad: si la gallina tiene 3 a;os, se corrobora
                //              si comio 4 veces, si la condicion se cumple devuelve true
                #endregion

                if (Edad >= 3) return Alimentos >= 4;
                if (Edad >= 2) return Alimentos >= 2;
                if (Edad >= 0) return Alimentos >= 1;

                return false;
            }
        }

        internal void Alimentar(int _cantidad)
        {
            Alimentos += _cantidad;
        }
        #endregion
    }
}

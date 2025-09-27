using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Gallinero
    {
        #region Punto lista privada
        private List<Gallina> ListaGallinas = new List<Gallina>();
        #endregion

        #region Punto delegate
        public List<Gallina> ListarGallinas()
        {
            return ListaGallinas;
        }

        public delegate void AlimentarGallinasDelegate(int _cantidad);
        public AlimentarGallinasDelegate AlimentarGallinas;

        public void AgregarGallina(Gallina X)
        {
            ListaGallinas.Add(X);
            AlimentarGallinas += X.Alimentar;
        }

        public void Alimentar(int _cantidad)
        {
            if (AlimentarGallinas != null)
            {
                AlimentarGallinas(_cantidad);
            }
        }
        #endregion
    }
}

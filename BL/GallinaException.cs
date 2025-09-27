using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class GallinaException : Exception
    {
        #region Exception personalizada
        public Gallina _gallina { get; set; }
        #endregion
    }
}

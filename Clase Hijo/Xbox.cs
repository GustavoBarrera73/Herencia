using App.Clase_Padre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Clase_Hijo
{
    internal class Xbox:ClsConsola
    {
        public string Xboxnormal { get; set; }
        public string MostrarDetalleXbox()
        {
            return Xboxnormal() + "Controlador:" + Xboxnormal;
        }
    }
}

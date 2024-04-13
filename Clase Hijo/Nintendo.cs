using App.Clase_Padre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Clase_Hijo
{
    internal class Nintendo:ClsConsola
    {
        public bool esPortable { get; set; }    

        public string MostrarDetalleNintendo()
        {
            string detallePadre = MostrarDetalles();
            return detallePadre + "Es Portable:" + esPortable;

        }
    }
}

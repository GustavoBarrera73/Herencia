using App.Clase_Padre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Clase_Hijo
{
    internal class PlayStation:ClsConsola
    { 
        public string ModeloControlador { get; set; }
        public string MostrarDetallePlay()
        {
            return MostrarDetalles() + "Controlador:" + ModeloControlador;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Clase_Padre
{
    internal class ClsConsola
    {
        public int anioLanzaminto { get; set; }

        public string Marca { get; set; } }
    
        public string MostrarDetalles()
    {
        return $"Marca: {Marca} Año: {anioLanzamiento}";
    }
}

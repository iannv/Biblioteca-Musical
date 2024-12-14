﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discos.Modelos
{
    internal class Disco
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [DisplayName("Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [DisplayName("Cantidad de canciones")]
        public int CantidadCanciones { get; set; }
        public string UrlImagenTapa { get; set; }
        [DisplayName("Género")]
        public Estilo Genero { get; set; }
        [DisplayName("Edición")]
        public TipoEdicion Edicion { get; set; }
    }
}

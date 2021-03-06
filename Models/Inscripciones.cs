﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace primerparcial19.Models
{
    public class Inscripciones
    {
        [Key]

        public int InscripcionId { get; set; }
        [Required(ErrorMessage ="El semestre no puede estar vacio")]
        public string Semestre { get; set; }
        [Required]
        [Range(minimum:1,maximum:27,ErrorMessage ="Cantidad de creditos no validos maximos 27")]
        public int Limite { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 27, ErrorMessage = "el limite de creditos tomados es 27")]
        public int Tomados { get; set; }
        public int Disponibles { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponibles=0;
        }
    }

    
}

﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Centinela.Core.DTOs
{
    public class UsuarioDTO
    {
        public int UsuarioId { get; set; }
        public string Correo { get; set; }
        public int EmpresaId { get; set; }
        public DateTime FechaLogin { get; set; }
        public DateTime? FechaLoginAnterior { get; set; }
        [Required]
        public string Observacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int TipoUsuario { get; set; }       
        public bool Activo { get; set; }
        public int Telefono { get; set; }
    }
}

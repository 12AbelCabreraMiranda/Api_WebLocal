using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi_Test.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required, MaxLength(50)]
        public string NombreEmpleado { get; set; }

        [Required, MaxLength(50)]
        public string Direccion { get; set; }


        [Required, MaxLength(50)]
        public string NombreUsuario { get; set; }

        [Required, MaxLength(225)]
        public string ContraseniaUsuario { get; set; }
    }
}
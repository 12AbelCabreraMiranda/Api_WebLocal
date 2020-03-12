using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc.Models
{
    public class mvcUsuario
    {
        public int UsuarioId { get; set; }

        
        [Required(ErrorMessage = "El campo {0} es requerido ")]
        [Display(Name = "Nombre")]
        public string NombreEmpleado { get; set; }
        
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        
        [Display(Name = "Usuario")]
        public string NombreUsuario { get; set; }
        
        [Display(Name = "Contraseña")]
        public string ContraseniaUsuario { get; set; }
    }
}
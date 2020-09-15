using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace coreSistema.Models.Usuarios
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage ="Por favor, ingrese un nombre")]
        public string Nombre { get; set; }

        [Display(Name ="Dirección")]
        public string Direccion { get; set; }
    }
}

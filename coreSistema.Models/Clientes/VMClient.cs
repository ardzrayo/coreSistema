using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace coreSistema.Models.Clientes
{
    public class VMClient
    {
        [Key]
        public int Idclient { get; set; }

        [Required(ErrorMessage = "Por favor, ingresa un nombre de cliente")]
        [Display(Name = "Nombre Cliente")]
        [StringLength(50, MinimumLength = 3)]
        public string Clientname { get; set; }

        [Required(ErrorMessage = "Por favor, ingresa el nombre completo del cliente")]
        [Display(Name = "Nombre Completo")]
        [StringLength(150, MinimumLength = 3)]
        public string Clientfullname { get; set; }

        [Required(ErrorMessage = "Por favor, ingresa el correo electrónico")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Clientemail { get; set; }

        [Required(ErrorMessage = "Por favor, ingresa un numero de teléfono")]
        [Display(Name = "Teléfono")]
        public string Clientphone { get; set; }

        [Required(ErrorMessage = "Por favor, ingresa un numero de teléfono de contacto")]
        [Display(Name = "Teléfono de contacto")]
        public string Clientcontact { get; set; }
        [Required(ErrorMessage = "Por favor, ingresa el correo electrónico")]
        [Display(Name = "Email contacto")]
        [EmailAddress]
        public string Emailcontact_tecnico { get; set; }

        [Display(Name = "Estado")]
        public bool Estado { get; set; }
        //public ICollection<VPS> vps { get; set; }
    }
}

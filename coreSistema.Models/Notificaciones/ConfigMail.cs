using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Notificaciones
{
    public class ConfigMail
    {
        [Key]
        public int Idperiodo { get; set; }

        [Required(ErrorMessage = "Por favor, ingresa un alias de notificación")]
        [Display(Name = "Alias")]
        [StringLength(50, MinimumLength = 3)]
        public string Nameperiodo { get; set; }

        [Display(Name = "Día")]
        public int Dia { get; set; }
        public string Asunto { get; set; }

        [Display(Name ="Cuerpo")]
        public string Cuerpomail { get; set; }
        public bool Estado { get; set; }
    }
}

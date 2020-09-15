using Sistema.Entidades.Servidores;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Entidades.Consumibles
{
    public class OSVersion
    {
        [Key]
        public int Idosversion { get; set; }

        [Required]
        public int Idos { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre de Network Bond.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe tener más de 50 caracteres, ni menos de 3 caracteres.")]
        [Display(Name ="OS Version")]
        public string Osversion { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }

        //Parametros para relacionar
        [ForeignKey("Idos")]
        public OSFamily OSFamily { get; set; }


        //public virtual OSFamily osfamily { get; set; }
        //public OSFamily osfamily { get; set; }
        //public ICollection<VPS> vps { get; set; }
    }
}

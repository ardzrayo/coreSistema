using Sistema.Entidades.Servidores;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Consumibles
{
    public class OSFamily
    {
        [Key]
        public int Idos { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre de Network Bond.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe tener más de 50 caracteres, ni menos de 3 caracteres.")]
        [Display(Name ="OS Family")]
        public string Osfamilyname { get; set; }

        [Display(Name = "Estado")]
        public bool Estado { get; set; }


        //public virtual ICollection<OSVersion> osversion { get; set; }
        //public ICollection<VPS> vps { get; set; }
    }
}

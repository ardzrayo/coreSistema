using Sistema.Entidades.Servidores;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Consumibles
{
    public class NetworkBond
    {
        [Key]
        public int Idnw { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre de Network Bond.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre no debe tener más de 50 caracteres, ni menos de 2 caracteres.")]
        [Display(Name ="Network Bond")]
        public string Nwbond { get; set; }

        [Display(Name = "Estado")]
        public bool Estado { get; set; }
        //public ICollection<VPS> vps { get; set; }
    }
}

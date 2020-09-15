using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Servidores
{
    public class Pool
    {
        [Key]
        public int Idpool { get; set; }
        [Required(ErrorMessage = "Ingrese un tipo de maquina virtual.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe tener más de 50 caracteres, ni menos de 3 caracteres.")]
        [Display(Name ="Pool Name")]
        public string Poolname { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        //public ICollection<VPS> vps { get; set; }
    }
}

using Sistema.Entidades.Servidores;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Consumibles
{
    public class SQLVersion
    {
        [Key]
        public int Idsqlversion { get; set; }
        public int Idsql { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre de Network Bond.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre no debe tener más de 50 caracteres, ni menos de 3 caracteres.")]
        [Display(Name ="Versión del gestor")]
        public string MSsqlversion { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        //public virtual SQLFamily sqlfamily { get; set; }
        //public ICollection<VPS> vps { get; set; }
    }
}

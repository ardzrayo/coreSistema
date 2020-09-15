using Sistema.Entidades.Servidores;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Consumibles
{
    public class SQLFamily
    {
        [Key]
        public int Idsql { get; set; }

        [Required(ErrorMessage = "Ingrese un nombre SQL.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El nombre no debe tener más de 50 caracteres, ni menos de 2 caracteres.")]
        [Display(Name ="Gestor DB")]
        public string Mssql { get; set; }
        public bool Estado { get; set; }
        //public virtual ICollection<SQLVersion> sqlversion { get; set; }
        //public ICollection<VPS> vps { get; set; }
    }
}

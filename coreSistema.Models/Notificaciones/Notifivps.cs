using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Notificaciones
{
    public class Notifivps
    {
        [Key]
        public int Idnotivps { get; set; }
        public int Idvps { get; set; }//llave foranea

        [Display(Name = "Nombre VPS")]
        public string Vmname { get; set; }
        public int Idclient { get; set; } //llave foranea

        [Display(Name = "Cliente")]
        public string Clientname { get; set; }

        [Display(Name = "Contacto")]
        public string Clientcontact { get; set; }

        [Display(Name = "Email")]
        public string Emailcontact_tecnico { get; set; }
        public bool Estado { get; set; }
        //public ICollection<NotifiHisto> notifihisto { get; set; } No va
        //Agregar llaves foraneas
    }
}

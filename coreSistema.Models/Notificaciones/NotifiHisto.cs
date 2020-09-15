using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Notificaciones
{
    public class NotifiHisto
    {
        [Key]
        public int Idhisto { get; set; }
        public string Fecha { get; set; }
        public string Destinatarios { get; set; }
        public int Asunto { get; set; }
        //public virtual Notifivps notifivps { get; set; }
    }
}

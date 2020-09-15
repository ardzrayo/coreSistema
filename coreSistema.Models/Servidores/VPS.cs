using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Entidades.Servidores
{
    public class VPS
    {
        [Key]
        public int Idvps { get; set; }
        public int Idclient { get; set; }

        [Required(ErrorMessage = "Por favor, ingresa un nombre de VPS")]
        [Display(Name = "VM Name")]
        [StringLength(50, MinimumLength = 3)]
        public string Vmname { get; set; }

        [Display(Name = "VM UUID")]
        public string Vmuuid { get; set; }

        [Display(Name = "CPU")]
        public int? Vcpus { get; set; }
        public int? Ram { get; set; }

        [Display(Name = "Hard Disk")]
        public int? Hdisk { get; set; }

        [Display(Name = "Bandwidth")]
        public int? Bandw { get; set; }
        public int Idnw { get; set; }
        //public int Idos { get; set; }//se omitira en esta ocasión

        [Display(Name = "Version OS")]
        public int Idversion { get; set; }
        //public int idsql { get; set; }//se omitira en esta ocasión

        [Display(Name = "Version SQL")]
        public int Idsqlversion { get; set; }

        [Display(Name = "IP Privada")]
        public string Internal_ip { get; set; }

        [Display(Name = "IP Pública")]
        public string External_ip { get; set; }

        [Display(Name = "Creado Por")]
        public DateTime createon { get; set; }
        //public int idusuario { get; set; }//Arreglar

        [Display(Name = "DNS")]
        public string Dnsname { get; set; }

        [Display(Name = "VM Type")]
        public int Idvmtype { get; set; }

        [Display(Name = "Pool")]
        public int Idpool { get; set; }

        [Display(Name = "Notas")]
        public string Notes { get; set; }

        //De esta forma este campo puede ser nulo
        [Display(Name = "RMT Access SAL")]
        public int? Rmtaccesssal { get; set; }
        public bool Estado { get; set; }

        //public virtual VMClient vmclient { get; set; }
        //public virtual NetworkBond networkbond { get; set; }
        //public virtual OSFamily osfamily { get; set; }
        //public virtual OSVersion osversion { get; set; }
        //public virtual SQLFamily sqlfamily { get; set; }
        //public virtual SQLVersion sqlversion { get; set; }
        //public virtual Usuario usuario { get; set; }
        //public virtual VMType vmtype { get; set; }
        //public virtual Pools pools { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using coreSistema.Models.Clientes;
using Sistema.Entidades.Consumibles;
using coreSistema.Models.Usuarios;
using Microsoft.AspNetCore.Identity;

namespace Sistema.Entidades.Servidores
{
    public class VPS
    {
        [Key]
        public int Idvps { get; set; }

        [Required]
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

        [Required]
        public int Idnw { get; set; }

        //public int Idos { get; set; }//se omitira en esta ocasión

        [Required]
        [Display(Name = "Version OS")]
        public int Idosversion { get; set; }

        //public int idsql { get; set; }//se omitira en esta ocasión

        [Required]
        [Display(Name = "Version SQL")]
        public int Idsqlversion { get; set; }

        [Display(Name = "IP Privada")]
        public string Internal_ip { get; set; }

        [Display(Name = "IP Pública")]
        public string External_ip { get; set; }

        [Display(Name = "Fecha de creación")]
        public string createon { get; set; }

        [Display(Name = "Creado por")]
        public string UsuarioId { get; set; }//Pruebas--

        [Display(Name = "DNS")]
        public string Dnsname { get; set; }

        [Required]
        [Display(Name = "VM Type")]
        public int Idvmtype { get; set; }

        [Required]
        [Display(Name = "Pool")]
        public int Idpool { get; set; }

        [Display(Name = "Notas")]
        public string Notes { get; set; }

        //De esta forma este campo puede ser nulo
        [Display(Name = "RMT Access SAL")]
        public int? Rmtaccesssal { get; set; }
        public bool Estado { get; set; }

        //Parametros para relacionar---------------------------------------------------------------
        [ForeignKey("Idclient")]
        public VMClient VMClient { get; set; }

        [ForeignKey("Idnw")]
        public NetworkBond NetworkBond { get; set; }

        [ForeignKey("Idosversion")]
        public OSVersion OSVersion { get; set; }

        [ForeignKey("Idsqlversion")]
        public SQLVersion SQLVersion { get; set; }

        [ForeignKey("UsuarioId")]
        public ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("Idvmtype")]
        public VMType VMType { get; set; }

        [ForeignKey("Idpool")]
        public Pool Pool { get; set; }

        //public virtual VMClient vmclient { get; set; }//
        //public virtual NetworkBond networkbond { get; set; }//
        //public virtual OSFamily osfamily { get; set; }No ira
        //public virtual OSVersion osversion { get; set; }//
        //public virtual SQLFamily sqlfamily { get; set; }No ira
        //public virtual SQLVersion sqlversion { get; set; }//
        //public virtual Usuario usuario { get; set; }-PENDIENTE
        //public virtual VMType vmtype { get; set; }//
        //public virtual Pool pool { get; set; }
    }
}
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Servidores;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.Models.ViewModels
{
    public class VPSVM
    {
        public VPS VPS { get; set; }
        public IEnumerable<SelectList> ListaVMClient { get; set; }
        public IEnumerable<SelectList> ListaNetworkBond { get; set; }
        public IEnumerable<SelectList> ListaOSVersion { get; set; }
        public IEnumerable<SelectList> ListaSQLVersion { get; set; }
        public IEnumerable<SelectList> ListaUsuario { get; set; }
        public IEnumerable<SelectList> ListaVMType { get; set; }
        public IEnumerable<SelectList> ListaPool { get; set; }

    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.Models.ViewModels
{
    public class OSVersionVM
    {
        public OSVersion OSVersion { get; set; }
        public IEnumerable<SelectList> ListaOSFamily { get; set; }
    }
}

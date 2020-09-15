using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.Models.ViewModels
{
    public class SQLVersionVM
    {
        public SQLVersion SQLVersion { get; set; }
        public IEnumerable<SelectList> ListaSQLFamily { get; set; }
    }
}

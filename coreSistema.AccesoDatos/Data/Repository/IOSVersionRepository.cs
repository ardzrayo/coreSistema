using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface IOSVersionRepository : IRepository<OSVersion>
    {
        IEnumerable<SelectListItem> GetListaOSVersion();

        void Update(OSVersion osversion);

        void Desactivar(OSVersion osversion);

        void Activar(OSVersion osversion);
    }
}

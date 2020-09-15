using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface IOSFamilyRepository : IRepository<OSFamily>
    {
        IEnumerable<SelectListItem> GetListaOSFamily();

        void Update(OSFamily osfamily);

        void Desactivar(OSFamily osfamily);

        void Activar(OSFamily osfamily);
    }
}

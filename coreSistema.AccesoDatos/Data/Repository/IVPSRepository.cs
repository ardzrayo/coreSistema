using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Servidores;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface IVPSRepository : IRepository<VPS>
    {
        IEnumerable<SelectListItem> GetListaVPS();
        void Update(VPS vps);
        void Desactivar(VPS vps);
        void Activar(VPS vps);
    }
}

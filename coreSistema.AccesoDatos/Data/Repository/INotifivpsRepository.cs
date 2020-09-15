using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Notificaciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface INotifivpsRepository : IRepository<Notifivps>
    {
        IEnumerable<SelectListItem> GetListaNotifivps();
        void Desactivar(Notifivps notifivps);
        void Activar(Notifivps notifivps);
    }
}

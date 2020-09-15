using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Notificaciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface INotifiHistoRepository : IRepository<NotifiHisto>
    {
        IEnumerable<SelectListItem> GetListaNotifiHisto();
    }
}

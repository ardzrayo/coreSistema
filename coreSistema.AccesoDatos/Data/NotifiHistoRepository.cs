using coreSistema.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Notificaciones;
using System.Collections.Generic;
using System.Linq;

namespace coreSistema.AccesoDatos.Data
{
    public class NotifiHistoRepository : Repository<NotifiHisto>, INotifiHistoRepository
    {
        private readonly ApplicationDbContext _db;
        public NotifiHistoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaNotifiHisto()
        {
            return _db.NotifiHisto.Select(i => new SelectListItem()
            {
                Text = i.Fecha,
                Value = i.Idhisto.ToString()
            });
        }
    }
}

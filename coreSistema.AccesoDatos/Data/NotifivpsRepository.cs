using coreSistema.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Notificaciones;
using System.Collections.Generic;
using System.Linq;

namespace coreSistema.AccesoDatos.Data
{
    public class NotifivpsRepository : Repository<Notifivps>, INotifivpsRepository
    {
        private readonly ApplicationDbContext _db;
        public NotifivpsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaNotifivps()
        {
            return _db.Notifivps.Select(i => new SelectListItem()
            {
                Text = i.Vmname,
                Value = i.Idnotivps.ToString()
            });
        }
        public void Activar(Notifivps notifivps)
        {
            var objDesdeDb = _db.Notifivps.FirstOrDefault(s => s.Idnotivps == notifivps.Idnotivps);
            objDesdeDb.Estado = true;
            _db.SaveChanges();
        }

        public void Desactivar(Notifivps notifivps)
        {
            var objDesdeDb = _db.Notifivps.FirstOrDefault(s => s.Idnotivps == notifivps.Idnotivps);
            objDesdeDb.Estado = false;
            _db.SaveChanges();
        }
    }
}

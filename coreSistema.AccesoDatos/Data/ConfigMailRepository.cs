using coreSistema.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Notificaciones;
using System.Collections.Generic;
using System.Linq;

namespace coreSistema.AccesoDatos.Data
{
    public class ConfigMailRepository : Repository<ConfigMail>, IConfigMailRepository
    {
        private readonly ApplicationDbContext _db;
        public ConfigMailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaConfigMail()
        {
            return _db.ConfigMail.Select(i => new SelectListItem()
            {
                Text = i.Nameperiodo,
                Value = i.Idperiodo.ToString()
            });
        }

        public void Update(ConfigMail configmail)
        {
            var objDesdeDb = _db.ConfigMail.FirstOrDefault(s => s.Idperiodo == configmail.Idperiodo);
            objDesdeDb.Nameperiodo = configmail.Nameperiodo;
            objDesdeDb.Dia = configmail.Dia;
            objDesdeDb.Asunto = configmail.Asunto;
            objDesdeDb.Cuerpomail = configmail.Cuerpomail;
            _db.SaveChanges();
        }

        public void Activar(ConfigMail configmail)
        {
            var objDesdeDb = _db.ConfigMail.FirstOrDefault(s => s.Idperiodo == configmail.Idperiodo);
            objDesdeDb.Estado = true;
            _db.SaveChanges();
        }

        public void Desactivar(ConfigMail configmaile)
        {
            var objDesdeDb = _db.ConfigMail.FirstOrDefault(s => s.Idperiodo == configmail.Idperiodo);
            objDesdeDb.Estado = false;
            _db.SaveChanges();
        }
    }
}

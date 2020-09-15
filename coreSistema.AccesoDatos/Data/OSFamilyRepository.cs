using coreSistema.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System.Collections.Generic;
using System.Linq;

namespace coreSistema.AccesoDatos.Data
{
    public class OSFamilyRepository : Repository<OSFamily>, IOSFamilyRepository
    {
        private readonly ApplicationDbContext _db;
        public OSFamilyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaOSFamily()
        {
            return _db.OSFamily.Select(i => new SelectListItem()
            {
                Text = i.Osfamilyname,
                Value = i.Idos.ToString()
            });
        }

        public void Update(OSFamily osfamily)
        {
            var objDesdeDb = _db.OSFamily.FirstOrDefault(s => s.Idos == osfamily.Idos);
            objDesdeDb.Osfamilyname = osfamily.Osfamilyname;
            _db.SaveChanges();
        }

        public void Activar(OSFamily osfamily)
        {
            var objDesdeDb = _db.OSFamily.FirstOrDefault(s => s.Idos == osfamily.Idos);
            objDesdeDb.Estado = true;
            _db.SaveChanges();
        }

        public void Desactivar(OSFamily osfamily)
        {
            var objDesdeDb = _db.OSFamily.FirstOrDefault(s => s.Idos == osfamily.Idos);
            objDesdeDb.Estado = false;
            _db.SaveChanges();
        }
    }
}

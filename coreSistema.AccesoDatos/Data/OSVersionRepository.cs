using coreSistema.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System.Collections.Generic;
using System.Linq;

namespace coreSistema.AccesoDatos.Data
{
    public class OSVersionRepository : Repository<OSVersion>, IOSVersionRepository
    {
        private readonly ApplicationDbContext _db;
        public OSVersionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaOSVersion()
        {
            return _db.OSVersion.Select(i => new SelectListItem()
            {
                Text = i.Osversion,
                Value = i.Idosversion.ToString()
            });
        }

        public void Update(OSVersion osversion)
        {
            var objDesdeDb = _db.OSVersion.FirstOrDefault(s => s.Idosversion == osversion.Idosversion);
            objDesdeDb.IdOS = osversion.IdOS;
            objDesdeDb.Osversion = osversion.Osversion;
            objDesdeDb.Descripcion = osversion.Descripcion;
            _db.SaveChanges();
        }

        public void Activar(OSVersion osversion)
        {
            var objDesdeDb = _db.OSVersion.FirstOrDefault(s => s.Idosversion == osversion.Idosversion);
            objDesdeDb.Estado = true;
            _db.SaveChanges();
        }

        public void Desactivar(OSVersion osversion)
        {
            var objDesdeDb = _db.OSVersion.FirstOrDefault(s => s.Idosversion == osversion.Idosversion);
            objDesdeDb.Estado = false;
            _db.SaveChanges();
        }
    }
}

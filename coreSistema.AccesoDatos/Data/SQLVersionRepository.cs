using coreSistema.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System.Collections.Generic;
using System.Linq;

namespace coreSistema.AccesoDatos.Data
{
    public class SQLVersionRepository : Repository<SQLVersion>, ISQLVersionRepository
    {
        private readonly ApplicationDbContext _db;
        public SQLVersionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaSQLVersion()
        {
            return _db.SQLVersion.Select(i => new SelectListItem()
            {
                Text = i.MSsqlversion,
                Value = i.Idsqlversion.ToString()
            });
        }

        public void Update(SQLVersion sqlversion)
        {
            var objDesdeDb = _db.SQLVersion.FirstOrDefault(s => s.Idsqlversion == sqlversion.Idsqlversion);
            objDesdeDb.Idsql = sqlversion.Idsql;
            objDesdeDb.MSsqlversion = sqlversion.MSsqlversion;
            objDesdeDb.Descripcion = sqlversion.Descripcion;
            _db.SaveChanges();
        }

        public void Activar(SQLVersion sqlversion)
        {
            var objDesdeDb = _db.SQLVersion.FirstOrDefault(s => s.Idsqlversion == sqlversion.Idsqlversion);
            objDesdeDb.Estado = true;
            _db.SaveChanges();
        }

        public void Desactivar(SQLVersion sqlversion)
        {
            var objDesdeDb = _db.SQLVersion.FirstOrDefault(s => s.Idsqlversion == sqlversion.Idsqlversion);
            objDesdeDb.Estado = false;
            _db.SaveChanges();
        }
    }
}

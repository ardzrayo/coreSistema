using coreSistema.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System.Collections.Generic;
using System.Linq;

namespace coreSistema.AccesoDatos.Data
{
    public class SQLFamilyRepository : Repository<SQLFamily>, ISQLFamilyRepository
    {
        private readonly ApplicationDbContext _db;
        public SQLFamilyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaSQLFamily()
        {
            return _db.SQLFamily.Select(i => new SelectListItem()
            {
                Text = i.Mssql,
                Value = i.Idsql.ToString()
            });
        }

        public void Update(SQLFamily sqlfamily)
        {
            var objDesdeDb = _db.SQLFamily.FirstOrDefault(s => s.Idsql == sqlfamily.Idsql);
            objDesdeDb.Mssql = sqlfamily.Mssql;
            //_db.SaveChanges();
        }

        public void Activar(SQLFamily sqlfamily)
        {
            var objDesdeDb = _db.SQLFamily.FirstOrDefault(s => s.Idsql == sqlfamily.Idsql);
            objDesdeDb.Estado = true;
            _db.SaveChanges();
        }

        public void Desactivar(SQLFamily sqlfamily)
        {
            var objDesdeDb = _db.SQLFamily.FirstOrDefault(s => s.Idsql == sqlfamily.Idsql);
            objDesdeDb.Estado = false;
            _db.SaveChanges();
        }
    }
}

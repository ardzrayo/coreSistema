using coreSistema.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using Sistema.Entidades.Servidores;
using System.Collections.Generic;
using System.Linq;

namespace coreSistema.AccesoDatos.Data
{
    public class PoolRepository : Repository<Pool>, IPoolRepository
    {
        private readonly ApplicationDbContext _db;
        public PoolRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaPool()
        {
            return _db.Pool.Select(i => new SelectListItem()
            {
                Text = i.Poolname,
                Value = i.Idpool.ToString()
            });
        }

        public void Update(Pool pool)
        {
            var objDesdeDb = _db.Pool.FirstOrDefault(s => s.Idpool == pool.Idpool);
            objDesdeDb.Poolname = pool.Poolname;
            objDesdeDb.Descripcion = pool.Descripcion;
            _db.SaveChanges();
        }

        public void Activar(Pool pool)
        {
            var objDesdeDb = _db.Pool.FirstOrDefault(s => s.Idpool == pool.Idpool);
            objDesdeDb.Estado = true;
            _db.SaveChanges();
        }

        public void Desactivar(Pool pool)
        {
            var objDesdeDb = _db.Pool.FirstOrDefault(s => s.Idpool == pool.Idpool);
            objDesdeDb.Estado = false;
            _db.SaveChanges();
        }
    }
}

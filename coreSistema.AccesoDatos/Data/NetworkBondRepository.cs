using coreSistema.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System.Collections.Generic;
using System.Linq;

namespace coreSistema.AccesoDatos.Data
{
    public class NetworkBondRepository : Repository<NetworkBond>, INetworkbondRepository
    {
        private readonly ApplicationDbContext _db;
        public NetworkBondRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaNetworkBond()
        {
            return _db.NetworkBond.Select(i => new SelectListItem()
            {
                Text = i.Nwbond,
                Value = i.Idnw.ToString()
            });
        }

        public void Update(NetworkBond networkbond)
        {
            var objDesdeDb = _db.NetworkBond.FirstOrDefault(s => s.Idnw == networkbond.Idnw);
            objDesdeDb.Nwbond = networkbond.Nwbond;
            //_db.SaveChanges();
        }

        public void Activar(NetworkBond networkbond)
        {
            var objDesdeDb = _db.NetworkBond.FirstOrDefault(s => s.Idnw == networkbond.Idnw);
            objDesdeDb.Estado = true;
            _db.SaveChanges();
        }

        public void Desactivar(NetworkBond networkbond)
        {
            var objDesdeDb = _db.NetworkBond.FirstOrDefault(s => s.Idnw == networkbond.Idnw);
            objDesdeDb.Estado = false;
            _db.SaveChanges();
        }
    }
}

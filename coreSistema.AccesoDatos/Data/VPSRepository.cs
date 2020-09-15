using coreSistema.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using Sistema.Entidades.Servidores;
using System.Collections.Generic;
using System.Linq;

namespace coreSistema.AccesoDatos.Data
{
    public class VPSRepository : Repository<VPS>, IVPSRepository
    {
        private readonly ApplicationDbContext _db;
        public VPSRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaVPS()
        {
            return _db.VPS.Select(i => new SelectListItem()
            {
                Text = i.Vmname,
                Value = i.Idvps.ToString()
            });
        }

        public void Update(VPS vps)
        {
            var objDesdeDb = _db.VPS.FirstOrDefault(s => s.Idvps == vps.Idvps);
            objDesdeDb.Idclient = vps.Idclient;
            objDesdeDb.Vmname = vps.Vmname;
            objDesdeDb.Vmuuid = vps.Vmuuid;
            objDesdeDb.Vcpus = vps.Vcpus;
            objDesdeDb.Ram = vps.Ram;
            objDesdeDb.Hdisk = vps.Hdisk;
            objDesdeDb.Bandw = vps.Bandw;
            objDesdeDb.Idnw = vps.Idnw;
            objDesdeDb.Idversion = vps.Idversion;
            objDesdeDb.Idsqlversion = vps.Idsqlversion;
            objDesdeDb.Internal_ip = vps.Internal_ip;
            objDesdeDb.External_ip = vps.External_ip;
            objDesdeDb.createon = vps.createon;
            objDesdeDb.Dnsname = vps.Dnsname;
            objDesdeDb.Idvmtype = vps.Idvmtype;
            objDesdeDb.Idpool = vps.Idpool;
            objDesdeDb.Notes = vps.Notes;
            objDesdeDb.Rmtaccesssal = vps.Rmtaccesssal;
            _db.SaveChanges();
        }

        public void Activar(VPS vps)
        {
            var objDesdeDb = _db.VPS.FirstOrDefault(s => s.Idvps == vps.Idvps);
            objDesdeDb.Estado = true;
            _db.SaveChanges();
        }

        public void Desactivar(VPS vps)
        {
            var objDesdeDb = _db.VPS.FirstOrDefault(s => s.Idvps == vps.Idvps);
            objDesdeDb.Estado = false;
            _db.SaveChanges();
        }
    }
}

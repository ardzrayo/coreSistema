using coreSistema.AccesoDatos.Data.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System.Collections.Generic;
using System.Linq;

namespace coreSistema.AccesoDatos.Data
{
    public class VMTypeRepository : Repository<VMType>, IVMTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public VMTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaVMType()
        {
            return _db.VMType.Select(i => new SelectListItem()
            {
                Text = i.Vmtypename,
                Value = i.Idvmtype.ToString()
            });
        }

        public void Update(VMType vmtype)
        {
            var objDesdeDb = _db.VMType.FirstOrDefault(s => s.Idvmtype == vmtype.Idvmtype);
            objDesdeDb.Vmtypename = vmtype.Vmtypename;
            _db.SaveChanges();
        }

        public void Activar(VMType vmtype)
        {
            var objDesdeDb = _db.VMType.FirstOrDefault(s => s.Idvmtype == vmtype.Idvmtype);
            objDesdeDb.Estado = true;
            _db.SaveChanges();
        }

        public void Desactivar(VMType vmtype)
        {
            var objDesdeDb = _db.VMType.FirstOrDefault(s => s.Idvmtype == vmtype.Idvmtype);
            objDesdeDb.Estado = false;
            _db.SaveChanges();
        }
    }
}

using coreSistema.AccesoDatos.Data.Repository;
using coreSistema.Models.Clientes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coreSistema.AccesoDatos.Data
{
    public class VMClientRepository : Repository<VMClient>, IVMClientRepository
    {
        private readonly ApplicationDbContext _db;
        public VMClientRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<SelectListItem> GetListaVMClient()
        {
            return _db.VMClient.Select(i => new SelectListItem()
            {
                Text = i.Clientname,
                Value = i.Idclient.ToString()
            });
        }

        public void Update(VMClient vmclient)
        {
            var objDesdeDb = _db.VMClient.FirstOrDefault(s => s.Idclient == vmclient.Idclient);
            objDesdeDb.Clientname = vmclient.Clientname;
            objDesdeDb.Clientfullname = vmclient.Clientfullname;
            objDesdeDb.Clientemail = vmclient.Clientemail;
            objDesdeDb.Clientphone = vmclient.Clientphone;
            objDesdeDb.Clientcontact = vmclient.Clientcontact;
            objDesdeDb.Emailcontact_tecnico = vmclient.Emailcontact_tecnico;
            //_db.SaveChanges();
        }

        public void Activar(VMClient vmclient)
        {
            var objDesdeDb = _db.VMClient.FirstOrDefault(s => s.Idclient == vmclient.Idclient);
            objDesdeDb.Estado = true;
            _db.SaveChanges();
        }

        public void Desactivar(VMClient vmclient)
        {
            var objDesdeDb = _db.VMClient.FirstOrDefault(s => s.Idclient == vmclient.Idclient);
            objDesdeDb.Estado = false;
            _db.SaveChanges();
        }
    }
}

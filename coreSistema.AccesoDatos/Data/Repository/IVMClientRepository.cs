using coreSistema.Models.Clientes;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface IVMClientRepository : IRepository<VMClient>
    {
        IEnumerable<SelectListItem> GetListaVMClient();

        void Update(VMClient vmclient);

        void Desactivar(VMClient vmclient);

        void Activar(VMClient vmclient);
    }
}

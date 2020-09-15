using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Servidores;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface IPoolRepository : IRepository<Pool>
    {
        IEnumerable<SelectListItem> GetListaPool();
        void Update(Pool pool);
        void Desactivar(Pool pool);
        void Activar(Pool pool);
    }
}

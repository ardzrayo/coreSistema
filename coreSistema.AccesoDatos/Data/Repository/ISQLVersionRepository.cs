using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface ISQLVersionRepository : IRepository<SQLVersion>
    {
        IEnumerable<SelectListItem> GetListaSQLVersion();

        void Update(SQLVersion sqlversion);

        void Desactivar(SQLVersion sqlversion);

        void Activar(SQLVersion sqlversion);
    }
}

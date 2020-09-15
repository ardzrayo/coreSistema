using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface ISQLFamilyRepository : IRepository<SQLFamily>
    {
        IEnumerable<SelectListItem> GetListaSQLFamily();

        void Update(SQLFamily sqlfamily);

        void Desactivar(SQLFamily sqlfamily);

        void Activar(SQLFamily sqlfamily);
    }
}

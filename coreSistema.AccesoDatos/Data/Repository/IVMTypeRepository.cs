using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface IVMTypeRepository : IRepository<VMType>
    {
        IEnumerable<SelectListItem> GetListaVMType();

        void Update(VMType vmtype);

        void Desactivar(VMType vmtype);

        void Activar(VMType vmtype);
    }
}

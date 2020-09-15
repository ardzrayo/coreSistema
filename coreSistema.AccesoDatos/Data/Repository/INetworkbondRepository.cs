using Microsoft.AspNetCore.Mvc.Rendering;
using Sistema.Entidades.Consumibles;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface INetworkbondRepository : IRepository<NetworkBond>
    {
        IEnumerable<SelectListItem> GetListaNetworkBond();

        void Update(NetworkBond networkbond);

        void Desactivar(NetworkBond networkbond);

        void Activar(NetworkBond networkbond);
    }
}

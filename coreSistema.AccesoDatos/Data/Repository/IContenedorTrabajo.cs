using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data.Repository
{
    public interface IContenedorTrabajo : IDisposable
    {
        IVMClientRepository VMClient { get; }
        INetworkbondRepository Networkbond { get; }
        IOSFamilyRepository OSFamily { get; }
        IOSVersionRepository OSVersion { get; }
        ISQLFamilyRepository SQLFamily { get; }
        ISQLVersionRepository SQLVersion { get; }
        IVMTypeRepository VMType { get; }
        IPoolRepository Pool { get; }
        IVPSRepository VPS { get; }
        IConfigMailRepository ConfigMail { get; }
        INotifivpsRepository Notifivps { get; }
        INotifiHistoRepository NotifiHisto { get; }

        void Save();
    }
}

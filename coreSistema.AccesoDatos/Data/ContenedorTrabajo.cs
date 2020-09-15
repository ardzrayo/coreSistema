using coreSistema.AccesoDatos.Data.Repository;
using Sistema.Entidades.Notificaciones;
using System;
using System.Collections.Generic;
using System.Text;

namespace coreSistema.AccesoDatos.Data
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;
            
        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;
            VMClient = new VMClientRepository(_db);
            Pool = new PoolRepository(_db);
            VPS = new VPSRepository(_db);
            Networkbond = new NetworkBondRepository(_db);
            OSFamily = new OSFamilyRepository(_db);
            OSVersion = new OSVersionRepository(_db);
            SQLFamily = new SQLFamilyRepository(_db);
            SQLVersion = new SQLVersionRepository(_db);
            VMType = new VMTypeRepository(_db);
            ConfigMail = new ConfigMailRepository(_db);
            Notifivps = new NotifivpsRepository(_db);
            NotifiHisto = new NotifiHistoRepository(_db);
        }
        public IVMClientRepository VMClient { get; private set; }
        public INetworkbondRepository Networkbond { get; private set; }
        public IOSFamilyRepository OSFamily { get; private set; }
        public IOSVersionRepository OSVersion { get; private set; }
        public ISQLFamilyRepository SQLFamily { get; private set; }
        public ISQLVersionRepository SQLVersion { get; private set; }
        public IVMTypeRepository VMType { get; private set; }
        public IPoolRepository Pool { get; private set; }
        public IVPSRepository VPS { get; private set; }
        public IConfigMailRepository ConfigMail { get; private set; }
        public INotifivpsRepository Notifivps { get; private set; }
        public INotifiHistoRepository NotifiHisto { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

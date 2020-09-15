using System;
using System.Collections.Generic;
using System.Text;
using coreSistema.Models.Clientes;
using coreSistema.Models.Usuarios;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sistema.Entidades.Consumibles;
using Sistema.Entidades.Notificaciones;
using Sistema.Entidades.Servidores;

namespace coreSistema.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<VMClient> VMClient { get; set; }
        public DbSet<NetworkBond> NetworkBond { get; set; }
        public DbSet<OSFamily> OSFamily { get; set; }
        public DbSet<OSVersion> OSVersion { get; set; }
        public DbSet<SQLFamily> SQLFamily { get; set; }
        public DbSet<SQLVersion> SQLVersion { get; set; }
        public DbSet<VMType> VMType { get; set; }
        public DbSet<ConfigMail> ConfigMail { get; set; }
        public DbSet<NotifiHisto> NotifiHisto { get; set; }
        public DbSet<Notifivps> Notifivps { get; set; }
        public DbSet<Pool> Pool { get; set; }
        public DbSet<VPS> VPS { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}

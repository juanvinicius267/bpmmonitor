using bpmmonitor.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpmmonitor.Data
{
    public class TeleMonitorContext : DbContext
    {
        public TeleMonitorContext(DbContextOptions<TeleMonitorContext> options)
            : base(options)
        {
        }
        public DbSet<Atendimentos> Atendimentos { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
        public DbSet<Doenca> Doencas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Hospitais> Hospitais { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Medicos> Medicos { get; set; }
        public DbSet<Pessoas> Pessoas { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Telemonitor> Telemonitores { get; set; }
   

    }
}

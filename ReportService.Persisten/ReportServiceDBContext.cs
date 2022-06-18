using Microsoft.EntityFrameworkCore;
using ReportService.Persistent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportService.Persistance
{
    public class ReportServiceDBContext : DbContext
    {
        public ReportServiceDBContext(DbContextOptions<ReportServiceDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ContactReportEntity).Assembly);
        }

        public DbSet<ContactReportEntity> ContactReportEntities { get; set; }
    }
}

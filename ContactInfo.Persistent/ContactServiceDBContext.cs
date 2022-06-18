using ContactInfo.Persistent.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.ServicePersistance
{
    public class ContactServiceDBContext : DbContext
    {
        public ContactServiceDBContext(DbContextOptions<ContactServiceDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ContactServiceDBContext).Assembly);
        }

        public DbSet<ContactEntity> ContactEntities { get; set; }
    }
}

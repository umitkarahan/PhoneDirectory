using ContactInfo.Persistent.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.ServicePersistance.Configuration
{
    internal class ContactEntityConfiguration : IEntityTypeConfiguration<ContactEntity>
    {
        public void Configure(EntityTypeBuilder<ContactEntity> builder)
        {
            builder
                .HasKey(i => i.Uuid).IsClustered(true);

            builder
                .Property(i => i.Uuid).ValueGeneratedNever();

            builder
                .Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
              .Property(i => i.Surname)
              .IsRequired()
              .HasMaxLength(50);

            builder
                .Property(i => i.Firm)
                .IsRequired(false)
                .HasMaxLength(100);
        }
    }
}

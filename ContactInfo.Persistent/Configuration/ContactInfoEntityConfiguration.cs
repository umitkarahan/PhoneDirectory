using Contact.ServicePersistent.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Contact.ServicePersistance.Configuration
{
    internal class ContactInfoEntityConfiguration : IEntityTypeConfiguration<ContactInfoEntity>
    {
        public void Configure(EntityTypeBuilder<ContactInfoEntity> builder)
        {
            builder
                .HasKey(i => i.Uuid)
                .IsClustered(true);

            builder.
                HasKey(i => i.ContactId)
                .IsClustered(false);

            builder
                .Property(i => i.ContactId)
                .IsRequired();

            builder
                .Property(i => i.Uuid)
                .ValueGeneratedNever();

            builder
                .Property(i => i.Type)
                .IsRequired();

            builder
              .Property(i => i.Content)
              .IsRequired()
              .HasMaxLength(100);
        }
    }
}

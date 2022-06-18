using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReportService.Persistent.Entities;


namespace ReportService.Persistance.Configuration
{
    internal class ContactReportConfiguration : IEntityTypeConfiguration<ContactReportEntity>
    {
        public void Configure(EntityTypeBuilder<ContactReportEntity> builder)
        {
            builder
                .HasKey(i => i.Uuid)
                .IsClustered(true);

            builder
              .Property(i => i.Uuid)
              .ValueGeneratedNever();

            builder
               .Property(i => i.Location)
               .IsRequired();

            builder
              .Property(i => i.NumberOfPeopleAtLocation)
              .IsRequired();

            builder
              .Property(i => i.NumberOfPhoneNumberAtLocation)
              .IsRequired();
        }
    }
}

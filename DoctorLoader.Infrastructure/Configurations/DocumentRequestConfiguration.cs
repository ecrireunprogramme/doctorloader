using DoctorLoader.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorLoader.Infrastructure.Configurations
{
    internal class DocumentRequestConfiguration : BaseEntityTypeConfiguration<DocumentRequest>
    {
        public override void Configure(EntityTypeBuilder<DocumentRequest> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Reference)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(e => e.Title)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(e => e.Description)
                .HasMaxLength(1000);
        }
    }
}

using DoctorLoader.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorLoader.Infrastructure.Configurations
{
    internal class DocumentConfiguration : BaseEntityTypeConfiguration<Document>
    {
        public override void Configure(EntityTypeBuilder<Document> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.Name)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(e => e.Size)
                .IsRequired();

            builder.HasOne(e => e.DocumentResponse)
                .WithMany(e => e.Documents)
                .IsRequired();
        }
    }
}

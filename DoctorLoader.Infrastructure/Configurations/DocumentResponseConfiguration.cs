using DoctorLoader.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorLoader.Infrastructure.Configurations
{
    internal class DocumentResponseConfiguration : BaseEntityTypeConfiguration<DocumentResponse>
    {
        public override void Configure(EntityTypeBuilder<DocumentResponse> builder)
        {
            base.Configure(builder);

            builder.HasOne(e => e.DocumentRequest);
        }
    }
}

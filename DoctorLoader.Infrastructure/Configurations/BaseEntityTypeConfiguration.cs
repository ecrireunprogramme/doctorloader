using DoctorLoader.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorLoader.Infrastructure.Configurations
{
    internal abstract class BaseEntityTypeConfiguration<TEntity> 
        : IEntityTypeConfiguration<TEntity> where TEntity : BaseAuditableEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Created)
                .IsRequired();

            builder.Property(e => e.CreatedBy);

            builder.Property(e => e.LastModified)
                .IsRequired();

            builder.Property(e => e.LastModifiedBy);

            // TODO: publier le projet dans le repository de ecrireunprogramme
        }
    }
}

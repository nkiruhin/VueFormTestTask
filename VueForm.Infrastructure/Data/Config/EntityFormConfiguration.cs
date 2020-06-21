using VueForm.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VueForm.Infrastructure.Data.Config
{
    public class EntityFormConfiguration : IEntityTypeConfiguration<EntityForm>
    {
        public void Configure(EntityTypeBuilder<EntityForm> builder)
        {
            builder
                .HasIndex(e => e.EntityId);
            
            builder.Property(t => t.EntityId)
                .IsRequired();
            
            builder.Property(t => t.Name)
                .IsRequired();
            
            builder.Property(t => t.Value)
                .IsRequired();
        }
    }
}

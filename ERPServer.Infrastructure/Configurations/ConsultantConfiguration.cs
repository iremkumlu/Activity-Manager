using ERPServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERPServer.Infrastructure.Configurations;
internal sealed class ConsultantConfiguration : IEntityTypeConfiguration<Consultant>
{
    public void Configure(EntityTypeBuilder<Consultant> builder)
    {
        builder.Property(p => p.Phone).HasColumnType("varchar(11)");
    }
}
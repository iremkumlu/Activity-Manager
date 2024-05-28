using ERPServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPServer.Infrastructure.Configurations;

internal  sealed class ActivityConfiguration : IEntityTypeConfiguration<Activity>
{
    public void Configure(EntityTypeBuilder<Activity> builder)
    {
        // aktiviteyi silersem projeyi silme ayarı
        builder.HasOne(p => p.Project).WithMany().OnDelete(DeleteBehavior.NoAction);
    }

}



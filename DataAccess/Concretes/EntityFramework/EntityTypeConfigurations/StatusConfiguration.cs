using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework.EntityTypeConfigurations;

public class StatusConfiguration : IEntityTypeConfiguration<Status>
{
    public void Configure(EntityTypeBuilder<Status> builder)
    {
        builder.ToTable("Statuses").HasKey(x=>x.Id);
        builder.Property(x=>x.Id).HasColumnName("Id").IsRequired();
        builder.Property(x=>x.Name).HasColumnName("Name").IsRequired();

        builder.HasMany(x => x.Duties);
    }
}

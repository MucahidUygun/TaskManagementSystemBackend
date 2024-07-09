using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework.EntityTypeConfigurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles").HasKey(t => t.Id);
        builder.Property(x => x.Id).HasColumnName("Id").IsRequired();
        builder.Property(x=>x.Name).HasColumnName("Name").IsRequired();

        builder.HasMany(x => x.Users);
    }
}

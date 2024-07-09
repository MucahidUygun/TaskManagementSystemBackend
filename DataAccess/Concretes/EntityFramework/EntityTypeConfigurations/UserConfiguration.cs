using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework.EntityTypeConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users").HasKey(t => t.Id);
        builder.Property(x=>x.Id).HasColumnName("Id").IsRequired();
        builder.Property(x => x.UserName).HasColumnName("UserName").IsRequired();
        builder.Property(x => x.Password).HasColumnName("Password").IsRequired();
        builder.Property(x => x.RoleId).HasColumnName("RoleId").IsRequired();

        builder.HasOne(x=>x.Role);
    }
}

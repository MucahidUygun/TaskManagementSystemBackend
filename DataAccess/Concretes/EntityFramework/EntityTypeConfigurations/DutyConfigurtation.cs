using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework.EntityTypeConfigurations;

public class DutyConfigurtation : IEntityTypeConfiguration<Duty>
{
    public void Configure(EntityTypeBuilder<Duty> builder)
    {
        builder.ToTable("Duties").HasKey(t => t.Id);
        builder.Property(x=>x.Id).HasColumnName("Id").IsRequired();
        builder.Property(x=>x.Title).HasColumnName("Title").IsRequired();
        builder.Property(x=>x.Description).HasColumnName("Description").IsRequired();
        builder.Property(x=>x.CreationDate).HasColumnName("CreationDate").IsRequired();
        builder.Property(x => x.StatusId).HasColumnName("StatusId").IsRequired();
        builder.Property(x=>x.UserId).HasColumnName("UserId").IsRequired();

        builder.HasOne(x => x.Status);
        builder.HasOne(x => x.User);
    }
}

using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Config
{
    public class PublicationConfiguration : IEntityTypeConfiguration<Publication>
    {
        public void Configure(EntityTypeBuilder<Publication> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).IsRequired().HasMaxLength(180);
            
            builder.Property(p => p.PictureUrl).IsRequired();
            builder.HasOne(b => b.Province).WithMany()
                .HasForeignKey(p => p.PublicationProvinceId);
            builder.HasOne(t => t.County).WithMany()
                .HasForeignKey(p => p.PublicationCountyId);

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.Data.Entities;
using WebDemo.Data.StatusE;

namespace WebDemo.Data.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Position).HasMaxLength(200);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(200);
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}

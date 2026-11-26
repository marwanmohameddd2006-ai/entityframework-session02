using Assignment_Session02_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session02_EFCore.Configurations
{
    internal class OrganizerProfileConfiguration : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
           builder.HasKey(op => op.OrganizerProfileId);
            builder.Property(op => op.Biography).IsRequired();
            builder.Property(op => op.Website).IsRequired();
            builder.Property(op => op.Logo).IsRequired();
            //Relationships Between OrganizerProfile and Organizer (One to One)
            builder.HasOne(op => op.Organizer)
                   .WithOne(o => o.OrganizerProfile)
                   .HasForeignKey<OrganizerProfile>(op => op.OrganizerId);
        }
    }
}

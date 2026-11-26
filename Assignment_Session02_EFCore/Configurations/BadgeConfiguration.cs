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
    internal class BadgeConfiguration : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> Badge)
        {
            Badge.HasKey(b => b.BadgeId);
            //Relationships Between Badge and Attendee (One to One)
            Badge.HasOne(b => b.Attendee)
                 .WithOne(a => a.Badge)
                 .HasForeignKey<Badge>(b => b.AttendeeId);

        }
    }
}

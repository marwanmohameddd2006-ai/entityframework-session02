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
    internal class EventConfiguration : IEntityTypeConfiguration<Event>

    {
        public void Configure(EntityTypeBuilder<Event> Event)
        {
           Event.HasKey(e => e.EventId);
            Event.Property(e => e.Title).IsRequired();
            Event.Property(e => e.Description).IsRequired();
            Event.Property(e => e.StartDate).IsRequired();
            Event.Property(e => e.MaximumAttendees).IsRequired();
            //Relationships Between Event and Organizer (Many to One)
            Event.HasOne(e => e.Organizer)
                 .WithMany(o => o.Events)
                 .HasForeignKey(e => e.OrganizerId);
        }
    }
}

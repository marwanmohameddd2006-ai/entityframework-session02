using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session02_EFCore.Models
{
    internal class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaximumAttendees { get; set; }

        //Relationships Between Event and Organizer (Many to One)
        public Organizer Organizer { get; set; } = null!; //Navigation Property
        public int OrganizerId { get; set; } //FK
    }
}

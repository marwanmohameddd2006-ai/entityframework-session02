using Assignment_Session02_EFCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session02_EFCore.Models
{
    internal class Badge
    {
        public int BadgeId { get; set; } //Unique Number for Each Attendee.
        public DateTime IssuedDate { get; set; }
        public TierTyp Tier { get; set; }


        //Relationships Between Badge and Attendee (One to One)
        public Attendee Attendee { get; set; } = null!; //Navigation Property
        public int AttendeeId { get; set; } //FK

    }
}

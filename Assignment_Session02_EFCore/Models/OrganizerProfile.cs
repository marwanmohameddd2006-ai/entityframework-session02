using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session02_EFCore.Models
{
    internal class OrganizerProfile
    {
        public int OrganizerProfileId { get; set; }
        public string Biography { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }


       
        public Organizer Organizer { get; set; } = null!; //Navigation Property 

        
        public int OrganizerId { get; set; } //FK
    }
}

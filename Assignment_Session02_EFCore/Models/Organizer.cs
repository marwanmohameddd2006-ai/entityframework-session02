using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session02_EFCore.Models
{
    [Table("EventOrganizers")]
    internal class Organizer
    {
        [Key]
        public int OrganizerId { get; set; } //PK
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(100, ErrorMessage = "Name Cannot exceed 100")]
        public string OrganizerName { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(150, ErrorMessage = "Name Cannot exceed 150")]
        public string ?CompanyName { get; set; }
        public bool VerifiedStatus { get; set; }


        //Relationships Between Organizer and OrganizerProfile (One to One)
        public OrganizerProfile OrganizerProfile { get; set; } = null!; //Navigation Property

        //Relationships Between Organizer and Event (One to Many)
        public ICollection<Event> Events { get; set; } = new List<Event>(); //Navigation Property
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Session02_EFCore.Models
{
    internal class Attendee
    {
        [Key]
        public int AttendeeId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(150, ErrorMessage = "Name Cannot exceed 150")]
        public string FullName { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(200, ErrorMessage = "Name Cannot exceed 200")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(150, ErrorMessage = "Name Cannot exceed 150")]
        public string Street { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(100, ErrorMessage = "Name Cannot exceed 100")]
        public string City { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(100, ErrorMessage = "Name Cannot exceed 100")]
        public string Country { get; set; }
        [Required]
        [Column( name: "ZipCode", TypeName = "varchar")]
        [MaxLength(20, ErrorMessage = "Name Cannot exceed 20")]
        public string PostalCode { get; set; }
        [NotMapped]
        public string FullAddress { get;  }

        //Relationships Between Attendee and Badge (One to One)
        public Badge? Badge { get; set; } //Navigation Property


    }
}

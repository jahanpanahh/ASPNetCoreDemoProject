using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Data
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string EmailId { get; set; }
        public string Notes { get; set; }
        public bool MemberStatus { get; set; }
    }
}

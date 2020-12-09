using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class MemberViewModel
    {
        [Display(Name = "Member ID")]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string EmailId { get; set; }
        public string Notes { get; set; }
        [Display(Name = "Member Status")]
        public bool MemberStatus { get; set; }
        [NotMapped]
        [Display(Name = "User Profile Picture")]
        public IFormFile ProfileImage { get; set; }
    }

    public class MemberListViewModel
    {
        [Display(Name = "Member ID")]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Notes { get; set; }
        [Display(Name = "Status")]
        public bool MemberStatus { get; set; }
    }
}

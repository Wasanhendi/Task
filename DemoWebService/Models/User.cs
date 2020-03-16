using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoWebService.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }
        public DateTime BirthOfDate { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
    }
}
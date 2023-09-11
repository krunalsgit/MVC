using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Krunal_Dhote_Task3.Models
{
    public class Student

    {
        public int StudentId { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = " Please Enter First Name.")]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " Please Enter Last Name.")]
        [MaxLength(100)]
        public string LastName{ get; set; }

        [Required(ErrorMessage = " Please enter Email.")]
        public string Email{get;set;}
        public string Password { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        [Range(15,50)]
        public string Age { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Krunal_Dhote_Task2.Models
{
    public class Student
    {
        public int Id;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int GraduationYear { get; set; }
        public int BranchId { get; set; }
        public int SectionId { get; set; }
    }
}
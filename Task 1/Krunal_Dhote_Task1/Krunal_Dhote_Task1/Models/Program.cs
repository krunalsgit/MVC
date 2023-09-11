using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Krunal_Dhote_Task1.Models
{
    public class Program
    {

        public static List<Student> StudentList = new List<Student>()
            {
                new Student() { Id = 1, Name = "Krunal Dhote", Email = "krunal.d@shaligram.com", Address = "Amravati", GraduationYear = 2023, BranchId=1,SectionId=1},
                new Student() { Id = 2, Name = "Piyush Sinha", Email = "piyush.d@shaligram.com", Address = "Bhopal", GraduationYear = 2023, BranchId=1,SectionId=2},
                new Student() { Id = 3, Name = "Shuvam Kunwer", Email = "shuvam.d@shaligram.com", Address = "Jamnagar", GraduationYear = 2023, BranchId=1,SectionId=2},
                new Student() { Id = 4, Name = "Varun Potrun", Email = "varun.d@shaligram.com", Address = "Shrikakulam", GraduationYear = 2023, BranchId=1,SectionId=3},
                new Student() { Id = 5, Name = "Bhaskar Rajale", Email = "bharskar.d@shaligram.com", Address = "SambhajiNagar", GraduationYear = 2023, BranchId=1,SectionId=3},
            };

        public static List<Branch> BranchList = new List<Branch>()
            {
                new Branch(){ Id=1,BranchName="CSE" },
                new Branch(){ Id=2,BranchName="Civil" },
                new Branch(){ Id=3,BranchName="Electrical" },
                new Branch(){ Id=4,BranchName="Mechanical" }
            };

        public static List<Section> SectionList = new List<Section>()
            {
                new Section(){ Id=1,SectionName="A" },
                new Section(){ Id=2,SectionName="B" },
                new Section(){ Id=3,SectionName="C" }
            };

    }
    public class ShowData
    {
        public int Id;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int GraduationYear { get; set; }
        public string Branch { get; set; }
        public string Section { get; set; }
    }
}
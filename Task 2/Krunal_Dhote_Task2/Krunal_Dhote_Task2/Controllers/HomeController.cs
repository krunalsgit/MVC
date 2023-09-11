using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Krunal_Dhote_Task2.Models;
namespace Krunal_Dhote_Task2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["Subheading"] = "This is the table of student information";
            TempData.Keep();
            return View();
        }

        public ActionResult About()
        {

            var JoinTable = (from student in Program.StudentList
                             join branch in Program.BranchList on
                             student.BranchId equals branch.Id
                             join section in Program.SectionList on student.SectionId equals section.Id
                             select new ShowData { Id = student.Id, Name = student.Name, Email = student.Email, Address = student.Address, Branch = branch.BranchName, Section = section.SectionName, GraduationYear = student.GraduationYear }).ToList();

            ViewBag.model = JoinTable;

            string Subheading;
            Subheading = TempData["Subheading"].ToString();
            TempData.Keep();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            
            return View();
        }

        public ActionResult Register()
        {
              return View();
        }


    }
}
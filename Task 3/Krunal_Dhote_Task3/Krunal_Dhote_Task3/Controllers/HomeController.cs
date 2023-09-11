using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Krunal_Dhote_Task3.Models;
using System.Web.Routing;
using MyModals;
using MVCDB.DbOperations;

namespace Krunal_Dhote_Task3.Controllers
{
    public class HomeController : Controller
    {
        StudentRepo stdRepo=null;

        //Constructor
        public HomeController()
        {
            stdRepo = new StudentRepo();
        }

        public ActionResult Index()
        {
            TempData["Subheading"] = "This is the table of student information";
            TempData.Keep();
            return View();
        }

       //Retrive Data Here
        public ActionResult About()
        {
            var data = stdRepo.getStudentData();
            return View(data);
        }


        public ActionResult Data()
        {
            var data = stdRepo.getStudentData().ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
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

        
        //Get Data
        public ActionResult Register()
        {
            return View();
        }


        //Post Data //Insert Methode
        [HttpPost]
        public ActionResult Register(StudentModal student)
        {
            if (ModelState.IsValid)
            {
                int id=stdRepo.addStudent(student);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.msg = "Data Added Successfully";
                    return RedirectToAction("About");
                }
            }
            return View();
        }

        //Delete Methode 
        public ActionResult DeleteData(int id)
        {
            stdRepo.deleteStudentData(id);
            return RedirectToAction("About");
        }


        //Details
        public ActionResult Edit(int id)
        {
            var data = stdRepo.getStudent(id);
            return View(data);
        }


        //Edit
        [HttpPost]
        public ActionResult Edit(StudentModal student)
        {
            if (ModelState.IsValid)
            {
                stdRepo.updateStudentData(student.id, student);
                return RedirectToAction("About");
            }
            return View();
        }

     
    }
}
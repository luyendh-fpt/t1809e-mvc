using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T1809E_MVC.Models;

namespace T1809E_MVC.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> list = new List<Student>();

        // GET: Student
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public  ActionResult Store(string fullName, string password)
        {
            Debug.WriteLine(fullName);
            Debug.WriteLine(password);
            var student = new Student()
            {
                FullName = fullName,
                Password = password
            };
            list.Add(student);
            ViewBag.CurrentStudent = student;
            return View();
        }

        public ActionResult List()
        {
            ViewBag.ListStudent = list;
            return View();
        }

    }
}
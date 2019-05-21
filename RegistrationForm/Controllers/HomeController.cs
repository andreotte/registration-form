using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationForm.Models;
using System.Text.RegularExpressions;

namespace RegistrationForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Result(Person inputPerson)
        {
            ViewBag.UserName = inputPerson.UserName;
            ViewBag.Email = inputPerson.Email;
            ViewBag.Password = inputPerson.Password;
            return View();
        }
    }
}
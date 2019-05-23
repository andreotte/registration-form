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
            ViewBag.Wolf = inputPerson.Wolf;
            ViewBag.Human = inputPerson.Human;
            ViewBag.Snake = inputPerson.Snake;
            ViewBag.Squach = inputPerson.Squach;
            ViewBag.Personality = inputPerson.Personality;
            ViewBag.ButtonClick = inputPerson.ButtonClick;
            return View();
        }

        public ActionResult PersonView(Person inputPerson)
        {
            ViewBag.UserName = inputPerson.UserName;
            ViewBag.Email = inputPerson.Email;
            ViewBag.Password = inputPerson.Password;
            ViewBag.Wolf = inputPerson.Wolf;
            ViewBag.Human = inputPerson.Human;
            ViewBag.Snake = inputPerson.Snake;
            ViewBag.Squach = inputPerson.Squach;
            ViewBag.Personality = inputPerson.Personality;
            ViewBag.ButtonClick = inputPerson.ButtonClick;
            return View();
        }
    }
}
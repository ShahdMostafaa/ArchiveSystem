using ArchiveSystem.Data;
using ArchiveSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ArchiveSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ArchiveContext _db;

        public HomeController(ArchiveContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        /// <summary>
        /// Displays the home page for a regular user.
        /// </summary>
        /// <returns>View with user account information.</returns>
        public IActionResult UserHome()
        {
            var userId = HttpContext.Session.GetInt32("ID");
            UserAcc account = _db.UserAccs.Where(s => s.UserAccID == userId).FirstOrDefault();

            if (account == null)
            {
                return new NotFoundResult();
            }

            return View(account);
        }

        /// <summary>
        /// Displays the home page for an admin user.
        /// </summary>
        /// <returns>View with admin account information.</returns>
        public IActionResult AdminHome()
        {
            var userId = HttpContext.Session.GetInt32("ID");
            UserAcc account = _db.UserAccs.Where(s => s.UserAccID == userId).FirstOrDefault();

            if (account == null)
            {
                return new NotFoundResult();
            }

            return View(account);
        }

        /// <summary>
        /// Displays the Login page for a user.
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login, bool loginAsAdmin)
        {
            string email = login.Email;
            string password = login.Password;

            UserAcc user = _db.UserAccs.Where(s => s.AcadMail == email && s.Pass == password && s.Active).FirstOrDefault();

            if (user == null || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ViewBag.ErrorMessage = "Please enter a valid email and password.";
                return View();
            }

            HttpContext.Session.SetInt32("ID", user.UserAccID);

            if (loginAsAdmin && !user.IsAdmin)
            {
                ViewBag.ErrorMessage = "You are not authorized to login as an admin.";
                return View();
            }
            else if (loginAsAdmin && user.IsAdmin)
            {
                return RedirectToAction("AdminHome", "Home");
            }
            else if (!loginAsAdmin && user.IsAdmin)
            {
                return RedirectToAction("AdminHome", "Home");

            }
            else
            {
                return RedirectToAction("UserHome", "Home");
            }

        }


        /// <summary>
        /// Displays the help page for the current user.
        /// </summary>
        /// <returns>View with user account information.</returns>
        public IActionResult Help()
        {
            var userId = HttpContext.Session.GetInt32("ID");
            UserAcc account = _db.UserAccs.Where(s => s.UserAccID == userId).FirstOrDefault();

            if (account == null)
            {
                return new NotFoundResult();
            }

            return View(account);
        }



        /// <summary>
        /// Renders the admin layout view.
        /// </summary>
        /// <returns>View with admin layout.</returns>
        public async Task<IActionResult> _AdminLayout()
        {
            var userId = HttpContext.Session.GetInt32("ID");

            if (userId == null)
            {
                return new NotFoundResult();
            }

            UserAcc account = await _db.UserAccs.FindAsync(userId);

            if (account == null)
            {
                return new NotFoundResult();
            }

            Gender userGender = account.userGender;

            ViewBag.UserGender = userGender.ToString();

            return View("~/Shared/_AdminLayout");
        }


        ///// <summary>
        ///// Renders the user layout view.
        ///// </summary>
        ///// <returns>View with user layout.</returns>
        //public IActionResult _UserLayout()
        //{
        //    var userId = HttpContext.Session.GetInt32("ID");
        //    UserAcc account = _db.UserAccs.Where(s => s.UserAccID == userId).FirstOrDefault();

        //    if (account == null)
        //    {
        //        return new NotFoundResult();
        //    }

        //    Gender userGender = account.userGender;

        //    ViewBag.UserGender = userGender.ToString();

        //    return View();
        //}
    }
}

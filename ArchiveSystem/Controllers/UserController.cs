using ArchiveSystem.Data;
using ArchiveSystem.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;

namespace ArchiveSystem.Controllers
{
    public class UserController : Controller
    {
        ArchiveContext Context;

        public UserController(ArchiveContext db)
        {
            Context = db;
        }

        [HttpPost]
        public JsonResult CheckEmail(string email)
        {
            using (var context = new ArchiveContext())
            {
                var user = context.UserAccs.FirstOrDefault(u => u.AcadMail == email);
                bool exists = (user != null);
                return Json(new { exists });
            }
        }


        /// <summary>
        /// Displays a page with all non-admin active users.
        /// </summary>
        /// <param name="query">Search query for filtering users by name or email.</param>
        /// <returns>View with a list of users.</returns>
        public IActionResult ShowAll(string query)
        {
            IQueryable<UserAcc> allUsersQuery = Context.UserAccs.AsNoTracking().Where(s => s.IsAdmin == false && s.Active);

            if (!string.IsNullOrEmpty(query))
            {
                allUsersQuery = allUsersQuery.Where(s => s.UserName.Contains(query) || s.AcadMail.Contains(query));
            }

            List<UserAcc> allUsers = allUsersQuery.OrderBy(m => m.UserName)
                                                   .ThenBy(m => m.AcadMail)
                                                   .ToList();

            ViewBag.AllUsers = allUsers;
            return View();
        }


        // GET: /User/addUser
        [HttpGet]
        public IActionResult addUser(UserAcc userAcc)
        {
            return View(userAcc);
        }

        // POST: /User/addUser
        [HttpPost]
        public IActionResult addUserPost(UserAcc userAcc)
        {
            using (var context = new ArchiveContext())
            {
                if (ModelState.IsValid)
                {
                    var emails = context.UserAccs.Where(s => s.AcadMail == userAcc.AcadMail).AsNoTracking().FirstOrDefault();
                    if (emails != null)
                    {
                        TempData["AlertMessage"] = "An account with the specified email already exists.";
                    }
                    else
                    {
                        var newUserAcc = new UserAcc
                        {
                            UserName = userAcc.UserName,
                            Phone = userAcc.Phone,
                            AcadMail = userAcc.AcadMail,
                            Pass = userAcc.Pass,
                            JobTitle = userAcc.JobTitle,
                            Department = userAcc.Department,
                            Active = true,
                            userGender = userAcc.userGender
                        };

                        context.UserAccs.Add(newUserAcc);
                        context.SaveChanges();

                        TempData["SuccessMessage"] = "User added successfully.";
                        return RedirectToAction("ShowAll", "User");
                    }
                }
                else
                {
                    TempData["ErrorMessage"] = "Invalid form submission.";
                    return View("/Views/User/addUser.cshtml");
                }
            }

            // If the execution reaches this point, it means there was an error
            return RedirectToAction("addUser", userAcc);
        }

        // GET: /User/editProfile
        [HttpGet]
        public IActionResult editProfile()
        {
            var Id = HttpContext.Session.GetInt32("ID");
            UserAcc Account = Context.UserAccs.Where(s => s.UserAccID == Id).FirstOrDefault();
            if (Account == null)
            {
                return new NotFoundResult();
            }
            return View(Account);
        }

        // POST: /User/editProfile
        [HttpPost]
        public IActionResult editProfile(UserAcc Account)
        {
            var Id = HttpContext.Session.GetInt32("ID");

            var findAccount = Context.UserAccs.Where(u => u.UserAccID == Id).FirstOrDefault();
            findAccount.UserName = Account.UserName ?? findAccount.UserName;
            findAccount.Phone = Account.Phone ?? findAccount.Phone;
            findAccount.Pass = Account.Pass ?? findAccount.Pass;

            Context.UserAccs.Update(findAccount);
            Context.SaveChanges();

            return RedirectToAction("Profile");
        }

        [HttpGet]
        public IActionResult editUser(int Id)
        {
            UserAcc Account = Context.UserAccs.Where(s => s.UserAccID == Id).AsNoTracking().FirstOrDefault();
            if (Account == null)
            {
                return new NotFoundResult();
            }
            return View(Account);
        }

        [HttpPost]
        public IActionResult editUser(UserAcc Account)
        {
            if (ModelState.IsValid)
            {
                Account.Active = true;

                // Load the entity into a new instance of the DbContext
                using (var newContext = new ArchiveContext())
                {
                    newContext.UserAccs.Update(Account);
                    newContext.SaveChanges();
                }

                return RedirectToAction("ShowAll", "User");
            }

            return View(Account);
        }

        [HttpGet]
        public IActionResult Delete(int ID)
        {
            var user = Context.UserAccs.Where(s => s.UserAccID == ID).AsNoTracking().FirstOrDefault();
            return View(user);

        }
        [HttpPost]
        public IActionResult Delete(UserAcc user)
        {
            var userAccount = Context.UserAccs.Where(s => s.UserAccID == user.UserAccID).AsNoTracking().FirstOrDefault();
            using (var newContext = new ArchiveContext())
            {
                userAccount.Active = false;
                Context.Update(userAccount);
                Context.SaveChanges();
            }
            
            RemovedUser User = new RemovedUser()
            {
                UserName = userAccount.UserName,
                AcadMail = userAccount.AcadMail,
                JobTitle = userAccount.JobTitle,
                Department = userAccount.Department
            };
            Context.RemoveUsers.Add(User);
            Context.SaveChanges();

            return RedirectToAction("ShowAll", "User");
        }

        [HttpGet]
        public IActionResult ShowAllRemoveUsers()
        {
            var RemoveUsers = Context.RemoveUsers.AsNoTracking().ToList();
            ViewBag.RemoveUsers = RemoveUsers;
            return View();
        }

        // GET: /User/Profile
        public IActionResult Profile()
        {
            var Id = HttpContext.Session.GetInt32("ID");
            UserAcc user = Context.UserAccs.Where(s => s.UserAccID == Id).FirstOrDefault();
            return View(user);
        }

    }
}

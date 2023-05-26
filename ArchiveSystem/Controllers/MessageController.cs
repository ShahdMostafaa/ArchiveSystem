using ArchiveSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;
using System;
using ArchiveSystem.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;

namespace ArchiveSystem.Controllers
{
    public class MessageController : Controller
    {
        ArchiveContext db;
        private IWebHostEnvironment _environment;
        public MessageController(ArchiveContext db, IWebHostEnvironment environment)
        {
            this.db = db;
            _environment = environment;

        }


        /// <summary>
        /// Imports messages sent by the user.
        /// </summary>
        /// <param name="query">Query string for filtering messages.</param>
        /// <returns>View with imported messages.</returns>
        public async Task<IActionResult> Import(string query, string sort)
        {
            var userId = HttpContext.Session.GetInt32("ID");

            var sentMessages = await db.ListUserMes
                .Where(l => l.UserId == userId)
                .Include(l => l.Message)
                .ToListAsync();

            List<Message> messages = new List<Message>();

            foreach (var item in sentMessages)
            {
                var message = db.Messages.Where(s => s.MessageId == item.MessageId).FirstOrDefault();

                Message messageSend = new Message()
                {
                    MessageId = item.MessageId,
                    Title = message.Title,
                    UserId = item.UserId,
                    SendDate = item.Message.SendDate,
                    MessageText = message.MessageText,
                    MessageAddress = message.MessageAddress,
                };
                messages.Add(messageSend);
            }

            if (!string.IsNullOrEmpty(query))
            {
                // Check if the query is a valid date
                if (DateTime.TryParse(query, out DateTime date))
                {
                    messages = messages.Where(m => m.UserId == userId && m.SendDate.HasValue && m.SendDate.Value.Date == date.Date).ToList();
                }
                else
                {
                    // Treat the query as text/email
                    messages = messages.Where(m => m.UserId == userId && (m.Title.Contains(query)) || m.MessageAddress.Contains(query)).ToList();
                }
            }
            else
            {
                messages = messages.Where(m => m.UserId == userId).ToList();
            }
            switch (sort)
            {
                case "send_date_asc":
                    messages = messages.OrderBy(m => m.SendDate).ToList();
                    break;
                case "send_date_desc":
                    messages = messages.OrderByDescending(m => m.SendDate).ToList();
                    break;
                case "title_asc":
                    messages = messages.OrderBy(m => m.Title).ToList();
                    break;
                case "title_desc":
                    messages = messages.OrderByDescending(m => m.Title).ToList();
                    break;

                default:
                    // Default sorting by Send Date ascending
                    messages = messages.OrderBy(m => m.SendDate).ToList();
                    break;
            }
            ViewBag.messages = messages;
            return View();
        }


        /// <summary>
        /// Exports messages sent by the user.
        /// </summary>
        /// <param name="query">Query string for filtering messages.</param>
        /// <returns>View with exported messages.</returns>
        public IActionResult Export(string query, string sort)
        {
            var userId = HttpContext.Session.GetInt32("ID");

            List<Message> messages = db.Messages.AsNoTracking().ToList();

            // Filter messages based on the search query
            if (!string.IsNullOrEmpty(query))
            {
                // Check if the query is a valid date
                if (DateTime.TryParse(query, out DateTime date))
                {
                    messages = messages.Where(m => m.UserId == userId && m.SendDate.HasValue && m.SendDate.Value.Date == date.Date).ToList();
                }
                else
                {
                    // Treat the query as text/email
                    messages = messages.Where(m => m.UserId == userId && (m.Title.Contains(query) || m.MessageDestination.Contains(query))).ToList();
                }
            }
            else
            {
                messages = messages.Where(m => m.UserId == userId).ToList();
            }

            // Sort messages based on the selected option
            switch (sort)
            {
                case "date_asc":
                    messages = messages.OrderBy(m => m.SendDate).ToList();
                    break;
                case "date_desc":
                    messages = messages.OrderByDescending(m => m.SendDate).ToList();
                    break;
                case "title_asc":
                    messages = messages.OrderBy(m => m.Title).ToList();
                    break;
                case "title_desc":
                    messages = messages.OrderByDescending(m => m.Title).ToList();
                    break;
                default:
                    // Default sorting by Send Date ascending
                    messages = messages.OrderBy(m => m.SendDate).ToList();
                    break;
            }

            ViewBag.messages = messages;

            return View();
        }


        // GET: /User/SendMessage
        [HttpGet]
        public IActionResult SendMessage()
        {
            var userId = HttpContext.Session.GetInt32("ID");
            //not Admin , not deleted , not you
            var UsersList = db.UserAccs.Where(s => !s.IsAdmin && s.Active && s.UserAccID != userId).Select(s => s.AcadMail).ToList();
            ViewBag.UsersList = UsersList;
            return View(new Message());
        }

        // POST: /User/SendMessage
        [HttpPost]
        public async Task<IActionResult> SendMessageAsync(Message messageData, List<IFormFile> AttFile)
        {
            if (ModelState.IsValid)
            {
                var Id = HttpContext.Session.GetInt32("ID");

                string selectedOptions = Request.Form["MessageDestinationVisible"];
                messageData.SendDate = DateTime.Now;
                messageData.UserId = Id;
                var userEmail = db.UserAccs.AsNoTracking().Where(ac => ac.UserAccID == Id).FirstOrDefault()?.AcadMail;
                messageData.MessageAddress = userEmail.ToString();
                messageData.MessageDestination = selectedOptions;

                // Save attachments to server and database
                List<_Attachment> attachments = new List<_Attachment>();
                foreach (var file in AttFile)
                {
                    if (file != null && file.Length > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var filePath = Path.Combine(_environment.WebRootPath, "Attachments", fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }
                        attachments.Add(new _Attachment { AttFile = fileName, AttDesc = filePath });
                    }
                }

                HttpContext.Session.SetInt32("MsID", messageData.MessageId);

                messageData.Attachments = attachments;

                db.Messages.Add(messageData);
                db.SaveChanges();


                // Split the string into an array of values
                string[] recipientEmails = selectedOptions.Split(",");
                foreach (var recipientEmail in recipientEmails)
                {
                    var userId = db.UserAccs.Where(ac => ac.AcadMail.Equals(recipientEmail)).AsNoTracking().FirstOrDefault()?.UserAccID;
                    if (userId != null)
                    {
                        ListUserMes userMesg = new ListUserMes()
                        {
                            UserId = userId.Value,
                            MessageId = messageData.MessageId
                        };

                        db.ListUserMes.Add(userMesg);
                    }
                }

                await db.SaveChangesAsync();

                return RedirectToAction("ViewMessage", new { id = messageData.MessageId });
            }
            else
            {
                ModelState.AddModelError("", "Failed to save data");
            }

            return View(messageData);
        }

        // GET: /User/ViewMessage
        public IActionResult ViewMessage(int id)
        {
            var messageDetails = db.Messages.Where(c => c.MessageId == id).FirstOrDefault();
            //  var userName= messageDetails.User.UserName.FirstOrDefault();
            return View(messageDetails);
        }

        // GET: /User/AttachmentView
        [HttpGet]
        public IActionResult AttachmentView(int id)
        {
            //var Id = HttpContext.Session.GetInt32("MsID");
            List<_Attachment> msgAttachments = db.Attachments.Where(am => am.MessageId == id).ToList();
            ViewBag.MessageAttachments = msgAttachments;
            return View();
        }


        [HttpGet]
        public IActionResult MesgDelUser(string email)
        {
            var userid = db.UserAccs.Where(e => e.AcadMail.Equals(email)).FirstOrDefault().UserAccID;
            var DelUserMesg = db.Messages.Where(u => u.UserId == userid).AsNoTracking().ToList();
            Dictionary<int, List<string>> ReciversEmailmesg = new Dictionary<int, List<string>>();
            List<string> Emails = new List<string>();
            foreach (var mesg in DelUserMesg)
            {
                var recipients = db.ListUserMes
                                   .Where(lum => lum.MessageId == mesg.MessageId)
                                   .Include(lum => lum.User)
                                   .Select(lum => lum.User.AcadMail)
                                   .ToList();

                ReciversEmailmesg[mesg.MessageId] = recipients;
            }
            ViewBag.Messages = DelUserMesg;
            ViewBag.Recipients = ReciversEmailmesg;
            return View();
        }
    }
}

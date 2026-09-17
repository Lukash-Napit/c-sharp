using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LukashPortfolio.Data;
using LukashPortfolio.Models;

namespace LukashPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContactRepository _repository;

        public HomeController()
        {
            _repository = new ContactRepository();
            // Automatically creates the database and ContactMessages table if missing
            _repository.EnsureTableExists();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Projects()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        // POST: Handles public contact form submission with DataAnnotation validation & Anti-CSRF protection
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactMessage model)
        {
            if (ModelState.IsValid)
            {
                _repository.SaveMessage(model);
                ViewBag.SuccessMessage = "Thank you! Your message has been sent to Lukash.";

                // Clear the form fields after successful submission
                ModelState.Clear();
                return View(new ContactMessage());
            }

            // If validation fails (e.g., regex/length checks), return form with error messages
            return View(model);
        }

        // GET: Protected Admin Inbox - Requires login cookie from AccountController
        [Authorize]
        [HttpGet]
        public IActionResult ViewMessages()
        {
            var messages = _repository.GetAllMessages();
            return View(messages);
        }

        // POST: Protected Delete Action - Requires login cookie and Anti-Forgery Token
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMessage(int id)
        {
            _repository.DeleteMessage(id);
            return RedirectToAction("ViewMessages");
        }
    }
}
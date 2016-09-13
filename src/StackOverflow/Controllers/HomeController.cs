using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StackOverflow.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace StackOverflow.Controllers
{
    public class HomeController : Controller
    {
        private QuestionDbContext db = new QuestionDbContext();
        public IActionResult Index()
        {
            return View(db.Questions.Include(questions => questions.User).ToList());
        }

        public IActionResult Details(int id)
        {
            var thisQuestion = db.Questions.Include(questions => questions.User).Include(questions => questions.Answers).FirstOrDefault(questions => questions.Id == id);
            return View(thisQuestion);
        }
    }
}

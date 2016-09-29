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
        private IQuestionRepository questionRepo;

        public HomeController(IQuestionRepository thisRepo = null)
        {
            if (thisRepo == null)
            {
                this.questionRepo = new EFQuestionRepository();
            }
            else
            {
                this.questionRepo = thisRepo;
            }
        }

        public IActionResult Index()
        {
            return View(questionRepo.Questions.Include(questions => questions.User).ToList());
        }

        public IActionResult Details(int id)
        {
            var thisQuestion = questionRepo.Questions.Include(questions => questions.User).Include(questions => questions.Answers).FirstOrDefault(questions => questions.Id == id);
            return View(thisQuestion);
        }
    }
}

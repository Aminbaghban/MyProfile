using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Data;
using MyProfile.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProfile.Controllers
{

    public class HomeController : Controller
    {
        private readonly ProfileDBContext context;

        public HomeController(ProfileDBContext ctx)
        {
            context = ctx;
        }
        //[Route("Amin/Amir/Hamid")]
        public IActionResult Index()
        {
            var model = context.Users;
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MyProfile.Models.User model)
        {
            context.Add(model);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var user = context.Users.Find(id);
            return View(user);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = context.Users.Find(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(MyProfile.Models.User model)
        {
            var user = context.Users.Find(model.Id);
            user.Name = model.Name;
            user.Age = model.Age;
           
            context.SaveChanges();

            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            var user = context.Users.Find(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Delete(MyProfile.Models.User model)
        {
            var user = context.Users.Find(model.Id);
            user.Name = model.Name;
            user.Age = model.Age;

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

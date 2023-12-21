using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Workers.Models;
using Workers.ViewModels;

namespace Workers.Controllers
{
    public class HomeController : Controller
    {
        private readonly WorkersDbContext db;

        public HomeController(WorkersDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Workers()
        {
            var workers = db.Workers.Include(x => x.Childrens).ToList();
            return View(workers);
        }

        [HttpGet]
        public IActionResult Childrens()
        {
            var childrens = db.Childrens.Include(x => x.Worker).ToList();
            return View(childrens);
        }

        [HttpGet]
        public IActionResult WorkerInfo(int id)
        {
            var worker = db.Workers.Include(x => x.Childrens).FirstOrDefault(x => x.Id == id);
            return View(worker);
        }

        [HttpGet]
        public IActionResult WorkerAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WorkerAdd(WorkerAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                Worker worker = new Worker
                {
                    LastName = model.LastName,
                    Name = model.Name,
                    Patronymic = model.Patronymic,
                    Gender = model.Gender,
                    Age = model.Age,
                    BirthdayDate = model.BirthdayDate,
                    FamilyStatus = model.FamilyStatus,
                    Post = model.Post,
                    Degree = model.Degree
                };

                db.Workers.Add(worker);
                db.SaveChanges();

                return Redirect("/");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult ChildAdd(int id)
        {
            ChildAddViewModel model = new ChildAddViewModel();
            model.WorkerId = id;
            return View(model);
        }

        [HttpPost]
        public IActionResult ChildAdd(ChildAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                Children child = new Children
                {
                    FIO = model.FIO,
                    Age = model.Age,
                    WorkerId = model.WorkerId
                };
                db.Childrens.Add(child);
                db.SaveChanges();
                return Redirect("/");
            }
            return View(model);
        }

        public IActionResult ChildDelete(int id)
        {
            var child = db.Childrens.FirstOrDefault(x => x.Id == id);
            if (child == null)
                return NotFound();
            db.Childrens.Remove(child);
            db.SaveChanges();
            return RedirectToAction("Childrens");
        }

        public IActionResult WorkerDelete(int id)
        {
            var worker = db.Workers.FirstOrDefault(x => x.Id == id);
            if(worker == null)
                return NotFound();
            db.Workers.Remove(worker);
            db.SaveChanges();
            return RedirectToAction("Workers");
        }
    }
}

using Internship_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Internship_Management_System.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var Result = _context.Students.ToList();
            return View(Result);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Student model)
        {
                _context.Students.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            
        }

        public ActionResult Edit(int Id)
        {
            var std = _context.Students.Where(s => s.studentId == Id).FirstOrDefault();
            return View(std);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Student std)
        {
            Student? ss;
             ss = _context.Students.Where(s => s.studentId == std.studentId).FirstOrDefault();
            _context.Students.Remove(ss);
            _context.Students.Add(std);

            return RedirectToAction("Index");
        }
    }


}


using Microsoft.AspNetCore.Mvc;
using StudentPortal.data;
using StudentPortal.Models;
using System.Reflection.Metadata.Ecma335;

namespace StudentPortal.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext context;
        public  StudentController (StudentDbContext context)
        {
            this.context = context;
        }
   
        public IActionResult Index()
        {
           var student = context.Students.ToList();
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student) {
            if (ModelState.IsValid)
            {
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                   

                }
            }
            return View(student);

        }

        [HttpGet]
        public IActionResult Edit(int?id) {
            if (id != null)
            {
                var student = context.Students.FirstOrDefault(a => a.Id == id);
                if (student != null)
                {
                    return View(student);
                }
                
            }
            return RedirectToAction("Index");

        }
        [HttpPost]
        public IActionResult Edit(Student student) {
            if (student != null) {
                context.Students.Update(student);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id) {
            if (id != null)
            {
                var student = context.Students.FirstOrDefault(a => a.Id == id);
                if (student != null)
                {
                    return View(student);
                }
               
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(Student student) {
            if (student != null) {
                context.Students.Remove(student);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                var student = context.Students.FirstOrDefault(a => a.Id == id);
                if (student != null) {
                    return View (student);
                }
              
            }
            return RedirectToAction("Index");   
               
        }
       

    }
}

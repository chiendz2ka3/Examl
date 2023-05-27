using Exam.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controllers
{
    public class ExamController : Controller
    {
        private readonly Context _context;

        public ExamController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<SubjectExam> lst = _context.SubjectExam.ToList();
            return View(lst);
        }

        [HttpGet]
          public IActionResult CreateView()
        {
            List<ClassRoom> lstclass = _context.classroom.ToList();
            List<Faculty> lstFaculy = _context.faculty.ToList();
            ViewBag.data1 = lstclass;
            ViewBag.data2 = lstFaculy;
            return View();
        }
        [HttpPost]
        public IActionResult Create(SubjectExam subject)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subject);
                _context.SaveChanges();
                return RedirectToAction("index");

            }
            return View(subject);
        }
    }
}

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


        public IActionResult Create()
        {

            return View();
        }
    }
}

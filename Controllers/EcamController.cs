using Exam.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controllers
{
    public class EcamController : Controller
    {
        private readonly Context _context;
        public EcamController(Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> GetAll()
        {
            List<SubjectExam> lst = _context.SubjectExam.ToList();
            if (lst != null)
            {
                ViewBag.SubjectExam = lst;
            }
            ViewBag.SubjectExam = null;
            return View();
        }
        public IActionResult index()
        {
            return View();
        }
    }
}

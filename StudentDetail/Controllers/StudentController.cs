using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using StudentData.Core.Model;
using StudentData.Core.IRepository;
using StudentData.Core.IServices;
using StudentData.Core.Model;

namespace StudentDetail.Controllers
{
    public class StudentController : Controller
    {

        private readonly IServices _services;
        public StudentController(IServices services)
        {
            _services = services;
        }
       
        public IActionResult StudentDashBoard()
        {
            List<Studentmodel> model = _services.StudentDashBoard();
            return View(model);
        }
        [HttpGet]
        public IActionResult SaveandUpdateStudentDetails(int id)
        {
            Studentmodel model = new Studentmodel();
            if ( id > 0)
            {
                 model = _services.GetStudentdetail(id);
                return View(model);
            }
            return View();
        }
        [HttpPost]
        public IActionResult SaveandUpdateStudentDetails(Studentmodel model)
        {

            if (model != null)
            {
                _services.SaveandUpdateStudentDetails(model);
                

            }
            return RedirectToAction("StudentDashBoard");
        }

        public ActionResult Delete(int id)
        {
            if (id  > 0)
            {
                _services.Delete(id);
            }
            return RedirectToAction("StudentDashBoard");
        }
    }
}

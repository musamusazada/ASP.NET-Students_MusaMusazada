using Microsoft.AspNetCore.Mvc;
using Students_MusaMusazada.HelperClasses;
using System.Collections.Generic;

namespace Students_MusaMusazada.Controllers
{
    public class StudentController : Controller
    {
        List<cStudent> StudentList = new List<cStudent>() {
            new cStudent("Musa", "Musazada", 49),
            new cStudent("Aytac", "Rajabli", 21),
            new cStudent("Iftixar ", "Qaraxanli", 20),
            new cStudent("Ali", "Isaxanli", 20),
            new cStudent("Ayxan", "Abdullayev", 21),
            new cStudent("Tofiq", "Ahmedov", 20),
            new cStudent("Vasif", "Unkown", 18),
            new cStudent("Tabriz", "Hajiyev", 18),
            new cStudent("Narmin", "Unknown", 22),
            new cStudent("Gunay", "Khalilova", 18),
            new cStudent("Vahid", "Efendiyev", 49)
            };
        public IActionResult Index(int? id)
        {
            //If exists, retrive the data!
            if (id!=null && (id.Value < StudentList.Capacity && id.Value >=1)) {

                cStudent student = StudentList[id.Value-1];
                ViewData["name"] = student.name;
                ViewData["surname"] = student.surname;
                ViewData["age"] = student.age;

                return View("Student");
                //Comment the line above and uncomment below to retrive the JSON!
                //return Json(new { Name= student.name, Surname= student.surname, Age=student.age});
            }

            //If Null or not such ID !
            ViewData["text"] = "No Student With Such ID"!;
            return View("NotFound");
           

        }
    }
}

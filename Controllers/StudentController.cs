using Microsoft.AspNetCore.Mvc;
using NDCuong114.Models;
namespace NDCuong114.Controllers
{
    public class StudentController : Controller
    {
        // viết các phương thức thao tác CRUD
        //Lấy dữ liệu của đối tượng Student
        public IActionResult Index()

        {
            //Khởi tạo list student
            List<Student> StdList = new List<Student>()
            {
                new Student{ StudentID=1, StudentName="Nguyễn Văn A", Age=18},
                new Student{ StudentID=2, StudentName="Nguyễn Văn B", Age=18},
                new Student{ StudentID=3, StudentName="Nguyễn Văn C", Age=18},
                new Student{ StudentID=4, StudentName="Nguyễn Văn D", Age=18},


            };
            ViewBag.DanhsachSV = StdList.Count();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
         ViewBag.sinhvien = std.StudentID + "-" + std.StudentName + "-" + std.Age;
         return View();
        }
        
    }
}
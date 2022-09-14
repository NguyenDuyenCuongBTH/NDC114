using Microsoft.AspNetCore.Mvc;
using NDCuong114.Models;
namespace NDCuong114.Controllers
{
   public class PersonController : Controller
   {
     public ActionResult Index()
     {
        List<Person> StdList= new List<Person>
        { 
            new Person { Age = 15, Address = "HaNoi", PhoneNumber = "0964220676" },
            new Person { Age = 18, Address = "HoTay", PhoneNumber = "0869246872" },
            new Person { Age = 15, Address = "HaNoi", PhoneNumber = "0986324156" },
        };
          ViewData["Person"] = StdList;
            return View();
     }
     [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Person std)
    {
       ViewBag.thongtin = std.Age + "-" + std.Address + "-" + std.PhoneNumber;
        return View();
    }
   }
}
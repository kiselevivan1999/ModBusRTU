using Microsoft.AspNetCore.Mvc;
using ModBusRTU.Models;

namespace ModBusRTU.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration() 
        {
            return View();
        }

        public IActionResult Input(User user) 
        {
            User checkUser = Project.users.Find(x => x.Email.Contains(user.Email));
            if (checkUser == null || user.Password != checkUser.Password) 
            {
                return View();
            }

            return Redirect("/");
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            if (!ModelState.IsValid) 
            {
                return View();
            }
            Project.users.Add(user);
            return Redirect("/authorization");
        }
    }
}

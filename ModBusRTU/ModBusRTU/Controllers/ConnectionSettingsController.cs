using Microsoft.AspNetCore.Mvc;
using ModBusRTU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModBusRTU.Controllers
{
    public class ConnectionSettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddDevice() 
        {
            return View();
        }

        public IActionResult Check(Device device)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            return View("Index");
        }
    }
}

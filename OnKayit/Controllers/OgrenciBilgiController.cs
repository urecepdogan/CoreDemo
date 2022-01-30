using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnKayit.Controllers
{
    public class OgrenciBilgiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

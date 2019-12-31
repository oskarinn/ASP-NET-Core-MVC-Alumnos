using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlumnosASPNETMVC.Models;
using System.Text.Encodings.Web;

namespace AlumnosASPNETMVC.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

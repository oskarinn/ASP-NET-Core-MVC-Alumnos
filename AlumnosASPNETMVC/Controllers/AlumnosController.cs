using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AlumnosASPNETMVC.Models;
using System.Text.Encodings.Web;
using AlumnosASPNETMVC.Data;
using Microsoft.AspNetCore.Hosting;

namespace AlumnosASPNETMVC.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public AlumnosController(IWebHostEnvironment env)
        {
            _env = env;
        }

        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        // POST
        [HttpPost]
        public IActionResult Create([Bind("Nombre,ApPaterno,ApMaterno,FechaNac,Genero,FechaIngreso,Activo,RFC")] AlumnoViewModel alumno)
        {
            string msg = "";

            if (ModelState.IsValid)
            {
                try
                {
                    // string webRootPath = _env.WebRootPath;
                    // AlumnosDataFile datafile = new AlumnosDataFile(webRootPath);
                    AlumnosDataFile datafile = new AlumnosDataFile();
                    datafile.Save(alumno);
                }
                catch (Exception e)
                {
                    msg = "No fue posible guardar la información. Reportelo al admin";
                    Console.WriteLine(e);
                }
                finally
                {
                    msg = "El registro fue creado satisfactoriamente";
                }
            }
            else
            {
                msg = "Al parecer los datos no son validos. Vuelva a intentarlo.";
            }

            TempData["msg"] = msg;

            return RedirectToAction("Index");
        }
    }
}
